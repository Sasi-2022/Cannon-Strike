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

    public void Start()
    {
        //currentlevel = 1;
        // playerDataSO.player.PlayerCurrentLevel = 1;
        PlayerPrefs.GetInt("playerlevel", 1);
        PlayerPrefs.Save();
          //int savedLevel = PlayerPrefs.GetInt("PlayerLevel", 1);
        //  Debug.Log("Player's saved level: " + savedLevel);*/
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


}
