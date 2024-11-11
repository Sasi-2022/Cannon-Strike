using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelButtons : MonoBehaviour
{

    public static LevelButtons instance;

    public Button[] levelbtns;

    

    public void Start()
    {
        LoadLevels();
    }

    public void Update()
    {
        LoadLevels();
    }

    public void LoadLevels()
    {
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel==1)
        {
            levelbtns[0].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 2)
        {
            levelbtns[1].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 3)
        {
            levelbtns[2].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 4)
        {
            levelbtns[3].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 5)
        {
            levelbtns[4].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 6)
        {
            levelbtns[5].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 7)
        {
            levelbtns[6].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 8)
        {
            levelbtns[7].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 9)
        {
            levelbtns[8].interactable = true;
        }


    }
}
