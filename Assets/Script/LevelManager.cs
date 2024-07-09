using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    #region Singletone
    public static LevelManager instance;
    #endregion

    #region Property
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
    #endregion

    public LevelDataSO levelData;
    public GameObject levelitem;
    public GameObject levelcontainer;
    private PlayerData playerData;

    private void Awake()
    {
        if (instance == null)
            instance = this;

       
    }
    // Start is called before the first frame update
    void Start()
    {
        LoadLevels();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevels()
    {
        levelData.levels.ForEach((e) =>
        {
            var a = Instantiate(levelitem, levelcontainer.transform);
            var b = a.GetComponent<LevelsHandler>();
          //  b.id = e.Id;
            b.leveltext.text = e.LevelsNo;
            b.id = playerDataSO.player.PlayerCurrentLevel;

        });
    }

    
}
