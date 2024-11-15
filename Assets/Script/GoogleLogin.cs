// <copyright file="SigninSampleScript.cs" company="Google Inc.">
// Copyright (C) 2017 Google Inc. All Rights Reserved.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations


using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Google;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using System.Collections;

public class GoogleLogin : MonoBehaviour
{
    public Text statusText;
    public string webClientId = "953055538475-hc0q9gvdpcf776hlc3obq3i559pb67rc.apps.googleusercontent.com"; // Replace with your actual Web Client ID
    private GoogleSignInConfiguration configuration;
    private string localDataPath;
    public static GoogleLogin instance;
    public bool googleLoginbool;
    public string username;
    public Sprite _profilePic;
    private string imageURL;
    public int currentlevel;
    public PlayerDataSO playerdata;

    [System.Serializable]
    public class UserData
    {
        public string displayName;
        public string email;
        public string userId;
        public int currentlevel;
    }

    [System.Serializable]
    public class AllUserData
    {
        public List<UserData> users = new List<UserData>();
    }

    private void Awake()
    {
        configuration = new GoogleSignInConfiguration
        {
            WebClientId = webClientId,
            RequestIdToken = true
        };

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }

        localDataPath = Application.persistentDataPath + "/GoogleData.json";
        LoadUserData();  
    }

    private void Start()
    {
        
    }

    public void OnSignIn()
    {
        GoogleSignIn.Configuration = configuration;
        GoogleSignIn.Configuration.UseGameSignIn = false;
        GoogleSignIn.Configuration.RequestIdToken = true;

        GoogleSignIn.DefaultInstance.SignOut();
        StartCoroutine(SignInCoroutine());
        googleLoginbool = true;
        LoadUserData();
    }

    IEnumerator SignInCoroutine()
    {
        yield return new WaitForSeconds(0.2f);
        GoogleSignIn.DefaultInstance.SignIn().ContinueWith(OnAuthenticationFinished);
        GoogleSignIn.DefaultInstance.SignIn().ContinueWith(OnDetails);
        yield return new WaitForSeconds(0.3f);

        SceneManager.LoadScene(1);  
    }

    public void OnSignOut()
    {
        Debug.Log("Signing out...");
        GoogleSignIn.DefaultInstance.SignOut();

        googleLoginbool = false;
        _profilePic = null;

        SceneManager.LoadScene(0);  
    }

    public void OnDisconnect()
    {
        AddStatusText("Calling Disconnect");
        GoogleSignIn.DefaultInstance.Disconnect();
    }

    internal void OnAuthenticationFinished(Task<GoogleSignInUser> task)
    {
        if (task.IsFaulted)
        {
            Debug.LogError("Authentication Failed: " + task.Exception.Message);
        }
        else if (task.IsCanceled)
        {
            Debug.LogError("Authentication Canceled");
        }
        else
        {
            Debug.Log("Authentication successful.");
            googleLoginbool = true;
        }
    }

    internal void OnDetails(Task<GoogleSignInUser> task)
    {
        if (task.IsCompletedSuccessfully)
        {
            username = task.Result.DisplayName;
            imageURL = task.Result.ImageUrl.ToString();
            SaveUserData(task.Result);
            Debug.Log("Profile Image URL: " + task.Result.ImageUrl.OriginalString);
            StartCoroutine(GetTexture(imageURL));
        }
        else
        {
            Debug.LogError("Failed to fetch user details.");
        }
    }

    IEnumerator GetTexture(string url)
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError($"ProfileTexture --> ERROR --> {www.error} {www.responseCode}");
        }
        else
        {
            Texture2D myTexture = ((DownloadHandlerTexture)www.downloadHandler).texture as Texture2D;

            if (myTexture != null)
            {
                _profilePic = Sprite.Create(myTexture, new Rect(0, 0, myTexture.width, myTexture.height), new Vector2(0.5f, 0.5f));
                Debug.Log("Profile Image Loaded.");
            }
            else
            {
                Debug.LogError("Profile image is null.");
            }
        }
    }

    private void SaveUserData(GoogleSignInUser user)
    {
        AllUserData allUserData = LoadAllUserDataFromFile();

        bool userExists = false;
        foreach (var savedUser in allUserData.users)
        {
            if (savedUser.userId == user.UserId)
            {
                
                savedUser.displayName = user.DisplayName;
                savedUser.email = user.Email;
                savedUser.currentlevel = playerdata.player.PlayerCurrentLevel;  
                userExists = true;
                break;
            }
        }

        
        if (!userExists)
        {
            UserData newUser = new UserData
            {
                displayName = user.DisplayName,
                email = user.Email,
                userId = user.UserId,
                currentlevel = playerdata.player.PlayerCurrentLevel  
            };
            allUserData.users.Add(newUser);
        }

        string jsonData = JsonUtility.ToJson(allUserData, true);
        Debug.Log("Saving All User Data: " + jsonData);

        try
        {
            File.WriteAllText(localDataPath, jsonData);
            Debug.Log("User data saved to file.");
        }
        catch (System.Exception ex)
        {
            Debug.LogError("Error saving user data: " + ex.Message);
        }

        
        PlayerPrefs.SetString("USERNAME", user.DisplayName);
        PlayerPrefs.SetString("EMAIL", user.Email);
        PlayerPrefs.SetString("USER_ID", user.UserId);
        PlayerPrefs.SetInt("Level", playerdata.player.PlayerCurrentLevel);  
        PlayerPrefs.Save();
    }

    private AllUserData LoadAllUserDataFromFile()
    {
        if (File.Exists(localDataPath))
        {
            string jsonData = File.ReadAllText(localDataPath);
            return JsonUtility.FromJson<AllUserData>(jsonData);
        }
        return new AllUserData();
    }

    private void LoadUserData()
    {
        string currentUserId = PlayerPrefs.GetString("USER_ID");  

        AllUserData allUserData = LoadAllUserDataFromFile();
        foreach (var user in allUserData.users)
        {
            if (user.userId == currentUserId)
            {
                
                currentlevel = user.currentlevel;
                playerdata.player.PlayerCurrentLevel = currentlevel;

               
                PlayerPrefs.SetInt("Level", currentlevel);
                PlayerPrefs.Save();

                AddStatusText("Welcome back: " + user.displayName);
                return;
            }
        }

        
        currentlevel = 1;
        playerdata.player.PlayerCurrentLevel = currentlevel;

        
        PlayerPrefs.SetInt("Level", 1);
        PlayerPrefs.Save();

        AddStatusText("New user! Starting at level 1.");
    }

    private void AddStatusText(string text)
    {
        if (statusText != null)
        {
            statusText.text = text;
        }
    }
}
