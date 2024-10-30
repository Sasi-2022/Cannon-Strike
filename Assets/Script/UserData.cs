using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UserData : MonoBehaviour
{


    private static UserData _instance;

    public static UserData Instance
    {
        get
        {
            if (_instance == null)
            {
                // Create a new GameObject if one doesn't exist
                GameObject singletonObject = new GameObject();
                _instance = singletonObject.AddComponent<UserData>();
                singletonObject.name = typeof(UserData).ToString() + " (Singleton)";

                // Optionally, make it persistent across scenes
                DontDestroyOnLoad(singletonObject);
            }
            return _instance;
        }
    }


    private void Awake()
    {
        // Ensure that this instance is the only one
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject); // Optional
    }

    public string UserId;
    public string UserName;
    public GameObject UserImage;
    public string email;
    public string levels;
    public string logintype;

}
