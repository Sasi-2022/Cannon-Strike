using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuestLoginManager : MonoBehaviour
{
    private const string GuestDataFileName = "userData.json";
    public static GuestLoginManager instance;
    public bool guestLoginbool;
    public string guestname;
    public int currentlevel;
    public PlayerDataSO playerdata;

    private string localDataPath;

    
    [System.Serializable]
    public class GuestData
    {
        public string guestId;
        public string guestName;
        public int currentLevel;  
    }

   
    [System.Serializable]
    public class AllGuestData
    {
        public List<GuestData> guestUsers = new List<GuestData>();
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }

        
        localDataPath = Application.persistentDataPath + "/" + GuestDataFileName;
        LoadGuestDataFromFile();
    }

    
    public void OnGuestLoginButtonClick()
    {
        if (!File.Exists(localDataPath))
        {
            
            GuestData guestData = new GuestData
            {
                guestId = System.Guid.NewGuid().ToString(),
                guestName = "Guest_" + UnityEngine.Random.Range(1, 9999).ToString(),
                currentLevel = 1 
            };

            SaveGuestData(guestData); 
            Debug.Log("Guest ID created: " + guestData.guestId);
            guestname = guestData.guestName;
            currentlevel = guestData.currentLevel; 
        }
        else
        {
            
            AllGuestData allGuestData = LoadGuestDataFromFile();
            foreach (var guest in allGuestData.guestUsers)
            {
                if (guest.guestId != null)
                {
                    guestname = guest.guestName;
                    currentlevel = guest.currentLevel; 
                    Debug.Log("Guest already logged in with ID: " + guest.guestId);
                    break;
                }
            }
        }

        
        SceneManager.LoadScene(1);
        guestLoginbool = true;
    }

    
    public void OnLogoutButtonClick()
    {
        if (File.Exists(localDataPath))
        {
            File.Delete(localDataPath); 
            Debug.Log("Guest data file deleted.");
        }

        
        guestLoginbool = false;
        SceneManager.LoadScene(0); 
    }

    
    private void SaveGuestData(GuestData guestData)
    {
        AllGuestData allGuestData = LoadGuestDataFromFile(); 
        allGuestData.guestUsers.Add(guestData); 

        string jsonData = JsonUtility.ToJson(allGuestData, true); 
        File.WriteAllText(localDataPath, jsonData); 
        Debug.Log("Guest data saved to file.");
    }

   
    private AllGuestData LoadGuestDataFromFile()
    {
        if (File.Exists(localDataPath)) 
        {
            string jsonData = File.ReadAllText(localDataPath); 
            return JsonUtility.FromJson<AllGuestData>(jsonData); 
        }
        else
        {
            Debug.LogError("Guest data file not found at: " + localDataPath);
            return new AllGuestData();  
        }
    }

   
    public void GetCurrentLevel()
    {
        AllGuestData allGuestData = LoadGuestDataFromFile();
        currentlevel = playerdata.player.PlayerCurrentLevel; // Assign the current level from the player data
    }

    
    public void IncrementLevel()
    {
        AllGuestData allGuestData = LoadGuestDataFromFile();
        
            GuestData guestData = allGuestData.guestUsers[0]; // Get the first guest in the list
            guestData.currentLevel = playerdata.player.PlayerCurrentLevel; // Update current level based on player data
            SaveGuestData(guestData); // Save the updated data
            Debug.Log("Level incremented to: " + guestData.currentLevel);
        
    }
}
