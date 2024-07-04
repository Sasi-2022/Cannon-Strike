using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneController : MonoBehaviour
{
    public LevelDataSO levelData;
   // public GameObject cannon;
    //public GameObject obstacle;
    public GameObject cannonparent;
    public GameObject obstacleparent;

    


    public void Start()
    {
        LoadData();
    }

    public void Update()
    {

        
    }



    public void LoadData()
    {

        var level = levelData.levels;
        if (GameplayController.instance.currentlevel == 1)
        {
            Instantiate(level[0].obstacle, obstacleparent.transform);
            Instantiate(level[0].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 2)
        {
            Instantiate(level[1].obstacle, obstacleparent.transform);
            Instantiate(level[1].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 3)
        {
            Instantiate(level[2].obstacle, obstacleparent.transform);
            Instantiate(level[2].cannon, cannonparent.transform);
        }

        if (GameplayController.instance.currentlevel == 4)
        {
            Instantiate(level[3].obstacle, obstacleparent.transform);
            Instantiate(level[3].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 5)
        {
            Instantiate(level[4].obstacle, obstacleparent.transform);
            Instantiate(level[4].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 6)
        {
            Instantiate(level[5].obstacle, obstacleparent.transform);
            Instantiate(level[5].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 7)
        {
            Instantiate(level[6].obstacle, obstacleparent.transform);
            Instantiate(level[6].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 8)
        {
            Instantiate(level[7].obstacle, obstacleparent.transform);
            Instantiate(level[7].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 9)
        {
            Instantiate(level[8].obstacle, obstacleparent.transform);
            Instantiate(level[8].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 10)
        {
            Instantiate(level[9].obstacle, obstacleparent.transform);
            Instantiate(level[9].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 11)
        {
            Instantiate(level[10].obstacle, obstacleparent.transform);
            Instantiate(level[10].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 12)
        {
            Instantiate(level[11].obstacle, obstacleparent.transform);
            Instantiate(level[11].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 13)
        {
            Instantiate(level[12].obstacle, obstacleparent.transform);
            Instantiate(level[12].cannon, cannonparent.transform);
        }

        if (GameplayController.instance.currentlevel == 14)
        {
            Instantiate(level[13].obstacle, obstacleparent.transform);
            Instantiate(level[13].cannon, cannonparent.transform);
        }

        if (GameplayController.instance.currentlevel == 15)
        {
            Instantiate(level[14].obstacle, obstacleparent.transform);
            Instantiate(level[14].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 16)
        {
            Instantiate(level[15].obstacle, obstacleparent.transform);
            Instantiate(level[15].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 17)
        {
            Instantiate(level[16].obstacle, obstacleparent.transform);
            Instantiate(level[16].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 18)
        {
            Instantiate(level[17].obstacle, obstacleparent.transform);
            Instantiate(level[17].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 19)
        {
            Instantiate(level[18].obstacle, obstacleparent.transform);
            Instantiate(level[18].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 20)
        {
            Instantiate(level[19].obstacle, obstacleparent.transform);
            Instantiate(level[19].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 21)
        {
            Instantiate(level[20].obstacle, obstacleparent.transform);
            Instantiate(level[20].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 22)
        {
            Instantiate(level[21].obstacle, obstacleparent.transform);
            Instantiate(level[21].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 23)
        {
            Instantiate(level[22].obstacle, obstacleparent.transform);
            Instantiate(level[22].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 24)
        {
            Instantiate(level[23].obstacle, obstacleparent.transform);
            Instantiate(level[23].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 25)
        {
            Instantiate(level[24].obstacle, obstacleparent.transform);
            Instantiate(level[24].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 26)
        {
            Instantiate(level[25].obstacle, obstacleparent.transform);
            Instantiate(level[25].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 27)
        {
            Instantiate(level[26].obstacle, obstacleparent.transform);
            Instantiate(level[26].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 28)
        {
            Instantiate(level[27].obstacle, obstacleparent.transform);
            Instantiate(level[27].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 29)
        {
            Instantiate(level[28].obstacle, obstacleparent.transform);
            Instantiate(level[28].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 30)
        {
            Instantiate(level[29].obstacle, obstacleparent.transform);
            Instantiate(level[29].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 31)
        {
            Instantiate(level[30].obstacle, obstacleparent.transform);
            Instantiate(level[30].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 32)
        {
            Instantiate(level[31].obstacle, obstacleparent.transform);
            Instantiate(level[31].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 33)
        {
            Instantiate(level[32].obstacle, obstacleparent.transform);
            Instantiate(level[32].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 34)
        {
            Instantiate(level[33].obstacle, obstacleparent.transform);
            Instantiate(level[33].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 35)
        {
            Instantiate(level[34].obstacle, obstacleparent.transform);
            Instantiate(level[34].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 36)
        {
            Instantiate(level[35].obstacle, obstacleparent.transform);
            Instantiate(level[35].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 37)
        {
            Instantiate(level[36].obstacle, obstacleparent.transform);
            Instantiate(level[36].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 38)
        {
            Instantiate(level[37].obstacle, obstacleparent.transform);
            Instantiate(level[37].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 39)
        {
            Instantiate(level[38].obstacle, obstacleparent.transform);
            Instantiate(level[38].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 40)
        {
            Instantiate(level[39].obstacle, obstacleparent.transform);
            Instantiate(level[39].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 41)
        {
            Instantiate(level[40].obstacle, obstacleparent.transform);
            Instantiate(level[40].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 42)
        {
            Instantiate(level[41].obstacle, obstacleparent.transform);
            Instantiate(level[41].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 43)
        {
            Instantiate(level[42].obstacle, obstacleparent.transform);
            Instantiate(level[42].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 44)
        {
            Instantiate(level[43].obstacle, obstacleparent.transform);
            Instantiate(level[43].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 45)
        {
            Instantiate(level[44].obstacle, obstacleparent.transform);
            Instantiate(level[44].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 46)
        {
            Instantiate(level[45].obstacle, obstacleparent.transform);
            Instantiate(level[45].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 47)
        {
            Instantiate(level[46].obstacle, obstacleparent.transform);
            Instantiate(level[46].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 48)
        {
            Instantiate(level[47].obstacle, obstacleparent.transform);
            Instantiate(level[47].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 49)
        {
            Instantiate(level[48].obstacle, obstacleparent.transform);
            Instantiate(level[48].cannon, cannonparent.transform);
        }
        if (GameplayController.instance.currentlevel == 50)
        {
            Instantiate(level[49].obstacle, obstacleparent.transform);
            Instantiate(level[49].cannon, cannonparent.transform);
        }
        /*  levelData.levels.ForEach((level) =>
          {
                  Instantiate(level.obstacle, obstacleparent.transform);
                  Instantiate(level.cannon, cannonparent.transform);
                 // if (UIManager.instance.iswin == true)
                //  {
                     // level.Id++;
                 // }
             // var a = Instantiate(cannon, cannonparent.transform);
             // var b = Instantiate(obstacle, obstacleparent.transform);

          });*/
    }
    }
