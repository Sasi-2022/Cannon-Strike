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
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 10)
        {
            levelbtns[9].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 11)
        {
            levelbtns[10].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 12)
        {
            levelbtns[11].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 13)
        {
            levelbtns[12].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 14)
        {
            levelbtns[13].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 15)
        {
            levelbtns[14].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 16)
        {
            levelbtns[15].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 17)
        {
            levelbtns[16].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 18)
        {
            levelbtns[17].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 19)
        {
            levelbtns[18].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 20)
        {
            levelbtns[19].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 21)
        {
            levelbtns[20].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 22)
        {
            levelbtns[21].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 23)
        {
            levelbtns[22].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 24)
        {
            levelbtns[23].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 25)
        {
            levelbtns[24].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 26)
        {
            levelbtns[25].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 27)
        {
            levelbtns[26].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 28)
        {
            levelbtns[27].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 29)
        {
            levelbtns[28].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 30)
        {
            levelbtns[29].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 31)
        {
            levelbtns[30].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel ==32)
        {
            levelbtns[31].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 33)
        {
            levelbtns[32].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 34)
        {
            levelbtns[33].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 35)
        {
            levelbtns[34].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 36)
        {
            levelbtns[35].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 37)
        {
            levelbtns[36].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 38)
        {
            levelbtns[37].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 39)
        {
            levelbtns[38].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 40)
        {
            levelbtns[39].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 41)
        {
            levelbtns[40].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 42)
        {
            levelbtns[41].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 43)
        {
            levelbtns[42].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 44)
        {
            levelbtns[43].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 45)
        {
            levelbtns[44].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 46)
        {
            levelbtns[45].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 47)
        {
            levelbtns[46].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 48)
        {
            levelbtns[47].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 49)
        {
            levelbtns[48].interactable = true;
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 50)
        {
            levelbtns[49].interactable = true;
        }
    }
}
