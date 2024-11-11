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
    using System.Threading.Tasks;
    using Google;
    using UnityEngine;
    using UnityEngine.UI;
    using UnityEngine.SceneManagement;
    using System.Collections;
    using System.IO;

public class GoogleLogin : MonoBehaviour
    {

        public Text statusText;

        public string webClientId = "953055538475-hc0q9gvdpcf776hlc3obq3i559pb67rc.apps.googleusercontent.com";

        private GoogleSignInConfiguration configuration;
    

    private string localDataPath;

    public static GoogleLogin instance;
    public bool googleLoginbool;
    public string username;
    public Sprite _profilePic;

    // Serializable class for saving user data as JSON
    [System.Serializable]
    public class UserData
    {
        public string displayName;
        public string email;
        public string userId;
    }

    private void Awake()
    {
        configuration = new GoogleSignInConfiguration
        {
            WebClientId = webClientId,
            RequestIdToken = true
        };

        // Set up path for saving the data locally
        

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            //instance = null;
            Destroy(gameObject);
        }
        localDataPath = Application.persistentDataPath + "/GoogleData.json";
        LoadUserData();
    }

    private void Start()
    {
        LoadUserData(); // Attempt to load user data when the app starts
    }

    public void OnSignIn()
    {
        GoogleSignIn.Configuration = configuration;
        GoogleSignIn.Configuration.UseGameSignIn = false;
        GoogleSignIn.Configuration.RequestIdToken = true;
        AddStatusText("Calling SignIn");
        GoogleSignIn.DefaultInstance.SignOut();
        StartCoroutine(SignInCoroutine());
    }

    IEnumerator SignInCoroutine()
    {
        yield return new WaitForSeconds(0.2f);
        GoogleSignIn.DefaultInstance.SignIn().ContinueWith(OnAuthenticationFinished);
    }

    public void OnSignOut()
    {
        Debug.Log("signout");
        AddStatusText("Calling SignOut");
        GoogleSignIn.DefaultInstance.SignOut();
        PlayerPrefs.DeleteKey("USERNAME");
        PlayerPrefs.DeleteKey("LOGIN");
        // Clear saved user data file
        if (File.Exists(localDataPath))
        {
            File.Delete(localDataPath);
        }

        // LoginPanel.gameObject.SetActive(true);
        SceneManager.LoadScene(0);
        googleLoginbool = false;
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
            Debug.Log("task.IsFaulted ");
            AddStatusText("Got Error: " + task.Exception.Message);
           // LoginPanel.gameObject.SetActive(true);
        }
        else if (task.IsCanceled)
        {
            Debug.Log("task.IsCanceled");
            AddStatusText("Canceled");
          //  LoginPanel.gameObject.SetActive(true);
        }
        else
        {
            Debug.Log("task.success ");
            AddStatusText("Welcome: " + task.Result.DisplayName + "!");
            username = "" + task.Result.DisplayName;
            // Save user data locally (PlayerPrefs and JSON file)
            SaveUserData(task.Result);
            StartCoroutine(LoadProfilePic(task.Result.ImageUrl.ToString()));
            // LoginPanel.gameObject.SetActive(true);
            SceneManager.LoadScene(1);
            googleLoginbool = true;
        }
    }

    public void OnSignInSilently()
    {
        GoogleSignIn.Configuration = configuration;
        GoogleSignIn.Configuration.UseGameSignIn = false;
        GoogleSignIn.Configuration.RequestIdToken = true;
        AddStatusText("Calling SignIn Silently");

        GoogleSignIn.DefaultInstance.SignInSilently()
              .ContinueWith(OnAuthenticationFinished);
    }

    public void OnGamesSignIn()
    {
        GoogleSignIn.Configuration = configuration;
        GoogleSignIn.Configuration.UseGameSignIn = true;
        GoogleSignIn.Configuration.RequestIdToken = false;

        AddStatusText("Calling Games SignIn");

        GoogleSignIn.DefaultInstance.SignIn().ContinueWith(
          OnAuthenticationFinished);
    }

    private List<string> messages = new List<string>();
    void AddStatusText(string text)
    {
        statusText.text += text + "\n";
        Debug.Log(statusText.text);
    }

    IEnumerator LoadProfilePic(string imageUrl)
    {
        WWW www = new WWW(imageUrl);
        yield return www;

        _profilePic = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0, 0));
        SceneManager.LoadScene(1);
    }

    // Save user data locally in a JSON file
    private void SaveUserData(GoogleSignInUser user)
    {
        UserData userData = new UserData
        {
            displayName = user.DisplayName,
            email = user.Email,
            userId = user.UserId
        };

        // Serialize to JSON and save to file
        string jsonData = JsonUtility.ToJson(userData, true);
        File.WriteAllText(localDataPath, jsonData);
        Debug.Log("User data saved to file.");

        // Also store basic info in PlayerPrefs (optional)
        PlayerPrefs.SetString("USERNAME", user.DisplayName);
        PlayerPrefs.SetString("EMAIL", user.Email);
        PlayerPrefs.SetString("USER_ID", user.UserId);
        PlayerPrefs.Save();
    }

    // Load user data from the JSON file
    private void LoadUserData()
    {
        if (File.Exists(localDataPath))
        {
            string jsonData = File.ReadAllText(localDataPath);
            UserData loadedData = JsonUtility.FromJson<UserData>(jsonData);
            AddStatusText("Welcome back: " + loadedData.displayName);
        }
        else
        {
            Debug.Log("No user data found. Please log in.");
        }
    }
}

