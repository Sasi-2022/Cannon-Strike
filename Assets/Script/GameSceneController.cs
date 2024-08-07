using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneController : MonoBehaviour
{
    public LevelDataSO levelData;
   // public GameObject cannon;
    //public GameObject obstacle;
    public GameObject cannonparent;
    public GameObject obstacleparent;
    private int currentlevel;
    public PlayerDataSO playerDataSO;
    public Button homeBtn;
    public Image levelheadername;
    


    public void Start()
    {
        int currentlevel = GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel;
        // GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel = 1;
        PlayerPrefs.GetInt("playerlevel", currentlevel);
        LoadData();

        homeBtn.onClick.AddListener(OnClickHomeBtn);

    }

    public void Update()
    {
        transform.rotation = Quaternion.identity;
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 34 || GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 44)
        {
            float distance = 2f;
            float speed = 2f;

            float yPos = transform.position.y;
            float zPos = transform.position.z;
            float xPos = Mathf.Sin(Time.time * speed) * distance;
            cannonparent.transform.position = new Vector3(xPos, yPos, zPos);
        }
    }

    public void OnClickHomeBtn()
    {
        SceneManager.LoadScene("EntryScene");
    }


    public void LoadData()
    {
        int currentlevel = GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel;
        var level = levelData.levels;
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel==1)
        {
              Instantiate(level[0].obstacle, obstacleparent.transform);
             Instantiate(level[0].cannon, cannonparent.transform);
            levelheadername.sprite = level[0].levelname;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
           // PlayerPrefs.Save();
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 2)
        {
            Instantiate(level[1].obstacle, obstacleparent.transform);
            Instantiate(level[1].cannon, cannonparent.transform);
            levelheadername.sprite = level[1].levelname;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
           // PlayerPrefs.Save();

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 3)
        {
            Instantiate(level[2].obstacle, obstacleparent.transform);
            Instantiate(level[2].cannon, cannonparent.transform);
            levelheadername.sprite = level[2].levelname;
            cannonparent.transform.position = level[2].position;
            level[2].rotation = Quaternion.Euler(new Vector3(0, 0, 47.5f));
            cannonparent.transform.rotation = level[2].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }

        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 4)
        {
            Instantiate(level[3].obstacle, obstacleparent.transform);
            Instantiate(level[3].cannon, cannonparent.transform);
            levelheadername.sprite = level[3].levelname;
            level[3].rotation = Quaternion.Euler(new Vector3(0, 0, -47.5f));
            cannonparent.transform.position = level[3].position;
            cannonparent.transform.rotation = level[3].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);

        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 5)
        {
            Instantiate(level[4].obstacle, obstacleparent.transform);
            Instantiate(level[4].cannon, cannonparent.transform);
            levelheadername.sprite = level[4].levelname;
            cannonparent.transform.position = level[4].position;
            cannonparent.transform.rotation = level[4].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 6)
        {
            Instantiate(level[5].obstacle, obstacleparent.transform);
            Instantiate(level[5].cannon, cannonparent.transform);
            levelheadername.sprite = level[5].levelname;
            cannonparent.transform.position = level[5].position;
            cannonparent.transform.rotation = level[5].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 7)
        {
            Instantiate(level[6].obstacle, obstacleparent.transform);
            Instantiate(level[6].cannon, cannonparent.transform);
            levelheadername.sprite = level[6].levelname;
            cannonparent.transform.position = level[6].position;
            cannonparent.transform.rotation = level[6].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 8)
        {
            Instantiate(level[7].obstacle, obstacleparent.transform);
            Instantiate(level[7].cannon, cannonparent.transform);
            levelheadername.sprite = level[7].levelname;
            level[7].rotation = Quaternion.Euler(new Vector3(0, 0, 44));
            cannonparent.transform.position = level[7].position;
            cannonparent.transform.rotation = level[7].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 9)
        {
            Instantiate(level[8].obstacle, obstacleparent.transform);
            Instantiate(level[8].cannon, cannonparent.transform);
            levelheadername.sprite = level[8].levelname;
            cannonparent.transform.position = level[8].position;
            cannonparent.transform.rotation = level[8].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 10)
        {
            Instantiate(level[9].obstacle, obstacleparent.transform);
            Instantiate(level[9].cannon, cannonparent.transform);
            levelheadername.sprite = level[9].levelname;
            cannonparent.transform.position = level[9].position;
            cannonparent.transform.rotation = level[9].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 11)
        {
            Instantiate(level[10].obstacle, obstacleparent.transform);
            Instantiate(level[10].cannon, cannonparent.transform);
            levelheadername.sprite = level[10].levelname;
            cannonparent.transform.position = level[10].position;
            level[10].rotation = Quaternion.Euler(new Vector3(0, 0, -45.5f));
            cannonparent.transform.rotation = level[10].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 12)
        {
            Instantiate(level[11].obstacle, obstacleparent.transform);
            Instantiate(level[11].cannon, cannonparent.transform);
            levelheadername.sprite = level[11].levelname;
            cannonparent.transform.position = level[11].position;
            cannonparent.transform.rotation = level[11].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 13)
        {
            Instantiate(level[12].obstacle, obstacleparent.transform);
            Instantiate(level[12].cannon, cannonparent.transform);
            levelheadername.sprite = level[12].levelname;
            cannonparent.transform.position = level[12].position;
            cannonparent.transform.rotation = level[12].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }

        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 14)
        {
            Instantiate(level[13].obstacle, obstacleparent.transform);
            Instantiate(level[13].cannon, cannonparent.transform);
            levelheadername.sprite = level[13].levelname;
            cannonparent.transform.position = level[13].position;
            cannonparent.transform.rotation = level[13].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }

        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 15)
        {
            Instantiate(level[14].obstacle, obstacleparent.transform);
            Instantiate(level[14].cannon, cannonparent.transform);
            levelheadername.sprite = level[14].levelname;
            level[14].rotation = Quaternion.Euler(new Vector3(0, 0, 63));
            cannonparent.transform.position = level[14].position;
            cannonparent.transform.rotation = level[14].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 16)
        {
            Instantiate(level[15].obstacle, obstacleparent.transform);
            Instantiate(level[15].cannon, cannonparent.transform);
            levelheadername.sprite = level[15].levelname;
            cannonparent.transform.position = level[15].position;
            cannonparent.transform.rotation = level[15].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 17)
        {
            Instantiate(level[16].obstacle, obstacleparent.transform);
            Instantiate(level[16].cannon, cannonparent.transform);
            levelheadername.sprite = level[16].levelname;
            cannonparent.transform.position = level[16].position;
            cannonparent.transform.rotation = level[16].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 18)
        {
            Instantiate(level[17].obstacle, obstacleparent.transform);
            Instantiate(level[17].cannon, cannonparent.transform);
            levelheadername.sprite = level[17].levelname;
            cannonparent.transform.position = level[17].position;
            cannonparent.transform.rotation = level[17].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 19)
        {
            Instantiate(level[18].obstacle, obstacleparent.transform);
            Instantiate(level[18].cannon, cannonparent.transform);
            levelheadername.sprite = level[18].levelname;
            cannonparent.transform.position = level[18].position;
            cannonparent.transform.rotation = level[18].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 20)
        {
            Instantiate(level[19].obstacle, obstacleparent.transform);
            Instantiate(level[19].cannon, cannonparent.transform);
            levelheadername.sprite = level[19].levelname;
            cannonparent.transform.position = level[19].position;
            cannonparent.transform.rotation = level[19].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 21)
        {
            Instantiate(level[20].obstacle, obstacleparent.transform);
            Instantiate(level[20].cannon, cannonparent.transform);
            levelheadername.sprite = level[20].levelname;
            level[20].rotation = Quaternion.Euler(new Vector3(0, 0, -51f));
            cannonparent.transform.position = level[20].position;
            cannonparent.transform.rotation = level[20].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 22)
        {
            Instantiate(level[21].obstacle, obstacleparent.transform);
            Instantiate(level[21].cannon, cannonparent.transform);
            levelheadername.sprite = level[21].levelname;
            cannonparent.transform.position = level[21].position;
            cannonparent.transform.rotation = level[21].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 23)
        {
            Instantiate(level[22].obstacle, obstacleparent.transform);
            Instantiate(level[22].cannon, cannonparent.transform);
            levelheadername.sprite = level[22].levelname;
            level[22].rotation = Quaternion.Euler(new Vector3(0, 0, 36f));
            cannonparent.transform.position = level[22].position;
            cannonparent.transform.rotation = level[22].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 24)
        {
            Instantiate(level[23].obstacle, obstacleparent.transform);
            Instantiate(level[23].cannon, cannonparent.transform);
            levelheadername.sprite = level[23].levelname;
            cannonparent.transform.position = level[23].position;
            level[23].rotation = Quaternion.Euler(new Vector3(0, 0, 84.7f));
            cannonparent.transform.rotation = level[23].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 25)
        {
            Instantiate(level[24].obstacle, obstacleparent.transform);
            Instantiate(level[24].cannon, cannonparent.transform);
            levelheadername.sprite = level[24].levelname;
            cannonparent.transform.position = level[24].position;
            cannonparent.transform.rotation = level[24].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 26)
        {
            Instantiate(level[25].obstacle, obstacleparent.transform);
            Instantiate(level[25].cannon, cannonparent.transform);
            levelheadername.sprite = level[25].levelname;
            cannonparent.transform.position = level[25].position;
            cannonparent.transform.rotation = level[25].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 27)
        {

            Instantiate(level[26].obstacle, obstacleparent.transform);
            Instantiate(level[26].cannon, cannonparent.transform);
            levelheadername.sprite = level[26].levelname;
            level[26].rotation = Quaternion.Euler(new Vector3(0, 0, 34f));
            cannonparent.transform.position = level[26].position;
            cannonparent.transform.rotation = level[26].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 28)
        {
            Instantiate(level[27].obstacle, obstacleparent.transform);
            Instantiate(level[27].cannon, cannonparent.transform);
            levelheadername.sprite = level[27].levelname;
            cannonparent.transform.position = level[27].position;
            level[27].rotation = Quaternion.Euler(new Vector3(0, 0, -33.05f));
            cannonparent.transform.rotation = level[27].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 29)
        {
            Instantiate(level[28].obstacle, obstacleparent.transform);
            Instantiate(level[28].cannon, cannonparent.transform);
            levelheadername.sprite = level[28].levelname;
            cannonparent.transform.position = level[28].position;
            cannonparent.transform.rotation = level[28].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 30)
        {
            Instantiate(level[29].obstacle, obstacleparent.transform);
            Instantiate(level[29].cannon, cannonparent.transform);
            levelheadername.sprite = level[29].levelname;
            cannonparent.transform.position = level[29].position;
            level[29].rotation = Quaternion.Euler(new Vector3(0, 0, -90f));
            cannonparent.transform.rotation = level[29].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 31)
        {
            Instantiate(level[30].obstacle, obstacleparent.transform);
            Instantiate(level[30].cannon, cannonparent.transform);
            levelheadername.sprite = level[30].levelname;
            cannonparent.transform.position = level[30].position;
            level[30].rotation = Quaternion.Euler(new Vector3(0, 0, 56));
            cannonparent.transform.rotation = level[30].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 32)
        {
            Instantiate(level[31].obstacle, obstacleparent.transform);
            Instantiate(level[31].cannon, cannonparent.transform);
            levelheadername.sprite = level[31].levelname;
            cannonparent.transform.position = level[31].position;
            cannonparent.transform.rotation = level[31].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 33)
        {
            Instantiate(level[32].obstacle, obstacleparent.transform);
            Instantiate(level[32].cannon, cannonparent.transform);
            levelheadername.sprite = level[32].levelname;
            cannonparent.transform.position = level[32].position;
            cannonparent.transform.rotation = level[32].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 34)
        {
            Instantiate(level[33].obstacle, obstacleparent.transform);
            Instantiate(level[33].cannon, cannonparent.transform);
            levelheadername.sprite = level[33].levelname;
            cannonparent.transform.position = level[33].position;
            

            
            cannonparent.transform.rotation = level[33].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 35)
        {
            Instantiate(level[34].obstacle, obstacleparent.transform);
            Instantiate(level[34].cannon, cannonparent.transform);
            levelheadername.sprite = level[34].levelname;
            cannonparent.transform.position = level[34].position;
            cannonparent.transform.rotation = level[34].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 36)
        {
            Instantiate(level[35].obstacle, obstacleparent.transform);
            Instantiate(level[35].cannon, cannonparent.transform);
            levelheadername.sprite = level[35].levelname;
            cannonparent.transform.position = level[35].position;
            level[35].rotation = Quaternion.Euler(new Vector3(0, 0, -31.8f));
            cannonparent.transform.rotation = level[35].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 37)
        {
            Instantiate(level[36].obstacle, obstacleparent.transform);
            Instantiate(level[36].cannon, cannonparent.transform);
            levelheadername.sprite = level[36].levelname;
            cannonparent.transform.position = level[36].position;
            cannonparent.transform.rotation = level[36].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 38)
        {
            Instantiate(level[37].obstacle, obstacleparent.transform);
            Instantiate(level[37].cannon, cannonparent.transform);
            levelheadername.sprite = level[37].levelname;
            cannonparent.transform.position = level[37].position;
            level[37].rotation = Quaternion.Euler(new Vector3(0, 0, -51.6f));
            cannonparent.transform.rotation = level[37].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 39)
        {
            Instantiate(level[38].obstacle, obstacleparent.transform);
            Instantiate(level[38].cannon, cannonparent.transform);
            levelheadername.sprite = level[38].levelname;
            cannonparent.transform.position = level[38].position;
            level[38].rotation = Quaternion.Euler(new Vector3(0, 0, 50.2f));
            cannonparent.transform.rotation = level[38].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 40)
        {
            Instantiate(level[39].obstacle, obstacleparent.transform);
            Instantiate(level[39].cannon, cannonparent.transform);
            levelheadername.sprite = level[39].levelname;
            cannonparent.transform.position = level[39].position;
            cannonparent.transform.rotation = level[39].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 41)
        {
            Instantiate(level[40].obstacle, obstacleparent.transform);
            Instantiate(level[40].cannon, cannonparent.transform);
            levelheadername.sprite = level[40].levelname;
            cannonparent.transform.position = level[40].position;
            cannonparent.transform.rotation = level[40].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 42)
        {
            Instantiate(level[41].obstacle, obstacleparent.transform);
            Instantiate(level[41].cannon, cannonparent.transform);
            levelheadername.sprite = level[41].levelname;
            cannonparent.transform.position = level[41].position;
            level[41].rotation = Quaternion.Euler(new Vector3(0, 0, 30.6f));
            cannonparent.transform.rotation = level[41].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 43)
        {
            Instantiate(level[42].obstacle, obstacleparent.transform);
            Instantiate(level[42].cannon, cannonparent.transform);
            levelheadername.sprite = level[42].levelname;
            cannonparent.transform.position = level[42].position;
            cannonparent.transform.rotation = level[42].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 44)
        {
            Instantiate(level[43].obstacle, obstacleparent.transform);
            Instantiate(level[43].cannon, cannonparent.transform);
            levelheadername.sprite = level[43].levelname;
            cannonparent.transform.position = level[43].position;
            cannonparent.transform.rotation = level[43].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 45)
        {
            Instantiate(level[44].obstacle, obstacleparent.transform);
            Instantiate(level[44].cannon, cannonparent.transform);
            levelheadername.sprite = level[44].levelname;
            cannonparent.transform.position = level[44].position;
            cannonparent.transform.rotation = level[44].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 46)
        {
            Instantiate(level[45].obstacle, obstacleparent.transform);
            Instantiate(level[45].cannon, cannonparent.transform);
            levelheadername.sprite = level[45].levelname;
            cannonparent.transform.position = level[45].position;
            cannonparent.transform.rotation = level[45].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 47)
        {
            Instantiate(level[46].obstacle, obstacleparent.transform);
            Instantiate(level[46].cannon, cannonparent.transform);
            levelheadername.sprite = level[46].levelname;
            cannonparent.transform.position = level[46].position;
            level[46].rotation = Quaternion.Euler(new Vector3(0, 0, 45));
            cannonparent.transform.rotation = level[46].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 48)
        {
            Instantiate(level[47].obstacle, obstacleparent.transform);
            Instantiate(level[47].cannon, cannonparent.transform);
            levelheadername.sprite = level[47].levelname;
            cannonparent.transform.position = level[47].position;
            cannonparent.transform.rotation = level[47].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 49)
        {
            Instantiate(level[48].obstacle, obstacleparent.transform);
            Instantiate(level[48].cannon, cannonparent.transform);
            levelheadername.sprite = level[48].levelname;
            cannonparent.transform.position = level[48].position;
            level[48].rotation = Quaternion.Euler(new Vector3(0, 0, -42.4f));
            cannonparent.transform.rotation = level[48].rotation;
            PlayerPrefs.SetInt("playerlevel", currentlevel);
        }
        if (GameplayController.instance.PlayerDataSO.player.PlayerCurrentLevel == 50)
        {
            Instantiate(level[49].obstacle, obstacleparent.transform);
            Instantiate(level[49].cannon, cannonparent.transform);
            levelheadername.sprite = level[49].levelname;
            cannonparent.transform.position = level[49].position;
            level[49].rotation = Quaternion.Euler(new Vector3(0, 0, -37.8f));
            cannonparent.transform.rotation = level[49].rotation;
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
