using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;
using UnityEngine.Android;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.SceneManagement;

public class FaceBookLogin : MonoBehaviour
{
    public TextMeshProUGUI FB_userName;
    public TextMeshProUGUI FB_userId;
    public Texture FB_userDp;
    private string localDataPath;
    public static FaceBookLogin instance;
    public bool facebookLoginbool;
    public string Name;

    // Serializable class to hold user data for JSON
    [System.Serializable]
    public class UserData
    {
        public string userId;
        public string userName;
        public string pictureURL;
    }

    private void Awake()
    {
        // Initialize Facebook SDK
        if (!FB.IsInitialized)
        {
            FB.Init(InitCallback);
        }
        else
        {
            FB.ActivateApp();
        }

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }

        localDataPath = Application.persistentDataPath + "/FacebookData.json";
        LoadLocalData(); // Load local data if available
    }

    private void InitCallback()
    {
        if (FB.IsInitialized)
        {
            FB.ActivateApp();
        }
        else
        {
            Debug.Log("Failed to initialize the Facebook SDK");
        }
    }

    private void SetInit()
    {
        if (FB.IsLoggedIn)
        {
            Debug.Log("Facebook is logged in!");
            string s = "client token " + FB.ClientToken + " User Id " + AccessToken.CurrentAccessToken.UserId;
            DealWithFbMenus(true);
        }
        else
        {
            Debug.Log("Facebook is not logged in!");
            DealWithFbMenus(false);
        }
    }

    private void DealWithFbMenus(bool isLoggedIn)
    {
        if (isLoggedIn)
        {
            FB.API("/me?fields=first_name", HttpMethod.GET, DisplayUsername);
            FB.API("/me/picture?type=square&height=128&width=128", HttpMethod.GET, DisplayProfilePic);
        }
        else
        {
            Debug.Log("Not logged in to Facebook");
        }
    }

    private void DisplayUsername(IResult result)
    {
        if (result.Error == null)
        {
            string name = result.ResultDictionary["first_name"].ToString();
            Name = name;
            FB_userName.text = name; // Update username on UI
            Debug.Log("Username: " + name);

            // Fetch additional data (ID, picture)
            FB.API("/me?fields=id", HttpMethod.GET, UserDataCallback);
        }
        else
        {
            Debug.Log(result.Error);
        }
    }

    public void Login()
    {
        if (!FB.IsLoggedIn)
        {
            FB.LogInWithReadPermissions(new List<string> { "public_profile", "email" }, LoginCallback);
        }
        else
        {
            Debug.Log("Already logged in to Facebook");
        }
    }

    private void LoginCallback(ILoginResult result)
    {
        if (FB.IsLoggedIn)
        {
            SetInit();
        }
        else
        {
            Debug.Log("Failed to log in");
        }
    }

    private void UserDataCallback(IGraphResult result)
    {
        if (result.Error != null)
        {
            Debug.Log("Error retrieving user data: " + result.Error);
        }
        else
        {
            var userData = result.ResultDictionary;
            string userId = userData["id"].ToString();
            string firstName = userData["first_name"].ToString();
            FB_userId.text = userId;

            // Save user data locally
            SaveLocalData(userId, firstName);

            // Now fetch the profile picture
            FB.API("/me/picture?redirect=false&type=large", HttpMethod.GET, DisplayProfilePic);

            facebookLoginbool = true;
            // Optionally transition to a new scene here after everything is loaded
            SceneManager.LoadScene(1);
        }
    }

    private void DisplayProfilePic(IGraphResult result)
    {
        if (result.Texture != null)
        {
            FB_userDp = result.Texture;
            // Optionally update UI with the profile picture (e.g., rawImg.texture)
            Debug.Log("Profile Pic loaded successfully.");
        }
        else
        {
            Debug.Log(result.Error);
        }
    }

    private void SaveLocalData(string userId, string userName, string pictureURL = "")
    {
        UserData userData = new UserData
        {
            userId = userId,
            userName = userName,
            pictureURL = pictureURL
        };

        string jsonData = JsonUtility.ToJson(userData);
        File.WriteAllText(localDataPath, jsonData);
        Debug.Log("Data saved locally.");
    }

    private void LoadLocalData()
    {
        if (File.Exists(localDataPath))
        {
            string jsonData = File.ReadAllText(localDataPath);
            UserData userData = JsonUtility.FromJson<UserData>(jsonData);

            FB_userId.text = userData.userId;
            FB_userName.text = userData.userName;

            if (!string.IsNullOrEmpty(userData.pictureURL))
            {
                Debug.Log("Data loaded from local storage.");
                // StartCoroutine(FetchProfilePicture(userData.pictureURL)); // If URL is stored, fetch the profile pic
            }
        }
        else
        {
            Debug.Log("No local data found.");
        }
    }

    private void DeleteLocalData()
    {
        if (File.Exists(localDataPath))
        {
            File.Delete(localDataPath);
            Debug.Log("Local data deleted.");
        }
    }

    public void LogOut()
    {
        if (FB.IsLoggedIn)
        {
            FB.LogOut();
            SceneManager.LoadScene(0); // Go back to the login scene
            facebookLoginbool = false;
            ResetUserData();
            DeleteLocalData(); // Remove local data on logout
        }
        else
        {
            Debug.Log("Not logged in to Facebook");
        }
    }

    private void ResetUserData()
    {
        FB_userName.text = "New User";
        FB_userId.text = "ID";
        FB_userDp = null;
    }

}
