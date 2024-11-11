using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameplayController : MonoBehaviour
{


    public static GameplayController instance;

    public PlayerData PlayerObj => playerData;
    public Player Player
    {
        get => playerData.PlayerInfo;
    }

    [SerializeField]
    PlayerDataSO playerDataSO;
    public PlayerDataSO PlayerDataSO
    {
        get => playerDataSO; set { playerDataSO.player = playerData.PlayerInfo; }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            Init();
            DontDestroyOnLoad(gameObject);
            return;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Init()
    {
       
      //  currentlevel = 1;
       // playerDataSO.player.PlayerCurrentLevel = 1;

        
    }

    public int currentlevel = 1;
    private PlayerData playerData;
    public static Action SavePlayerData;

    private int currentLevel; // Store the current level
    private const string LevelKey = "currentLevel";

    public void Start()
    {
        currentlevel = 1;
         playerDataSO.player.PlayerCurrentLevel = 1;
        PlayerPrefs.GetInt("playerlevel", 1);
        PlayerPrefs.Save();
          int savedLevel = PlayerPrefs.GetInt("PlayerLevel", 1);
          Debug.Log("Player's saved level: " + savedLevel);
        LoadLevel();
    }

    private void OnEnable()
    {
        SavePlayerData += SaveUserDataInPlayerPrefs;
       
    }

    private void OnDisable()
    {
        SavePlayerData -= SaveUserDataInPlayerPrefs;
       
    }

    private void UpdatePlayerData()
    {
        playerData.RetrievePlayerData();
    }

    private void SaveUserDataInPlayerPrefs()
    {
        try
        {
            //SaveToFile();
            playerDataSO.player = Player;
        }
        catch (Exception ex)
        {
            Debug.Log("qqq");
        }
    }

    // Get the current level
    public int GetCurrentLevel()
    {
        return currentLevel;
    }

    // Set the current level (usually called when progressing to the next level)
    public void SetCurrentLevel(int level)
    {
        currentLevel = level;
        SaveLevel(); // Optionally, save the current level after updating
    }

    // Increment the current level (when progressing to the next level)
    public void IncrementLevel()
    {
        currentLevel++;
        SaveLevel();
    }

    // Save the current level to PlayerPrefs (so it persists across sessions)
    private void SaveLevel()
    {
        PlayerPrefs.SetInt(LevelKey, currentLevel);
        PlayerPrefs.Save(); // Make sure the data is saved immediately
    }

    // Load the level from PlayerPrefs (loads the saved level when the game starts)
    private void LoadLevel()
    {
        currentLevel = PlayerPrefs.GetInt(LevelKey, 1); // Default to level 1 if not set
    }


}
