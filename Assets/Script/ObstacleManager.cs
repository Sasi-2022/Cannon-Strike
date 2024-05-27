using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ObstacleManager : MonoBehaviour
{
   // public int id;
   // public LevelDataSO levelData;
    public GameObject obstacleparent;
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public GameObject obstacle5;
    public GameObject obstacle6;
    public GameObject obstacle7;
    public GameObject obstacle8;
    public GameObject obstacle9;


    /*  private void OnEnable()
      {
          Levels.level1 += LoadObtacle1;
          Levels.level2 += LoadObtacle2;
          Levels.level3 += LoadObtacle3;
          Levels.level4 += LoadObtacle4;
      }

      private void OnDisable()
      {
          Levels.level1 -= LoadObtacle1;
          Levels.level2 -= LoadObtacle2;
          Levels.level3 -= LoadObtacle3;
          Levels.level4 -= LoadObtacle4;
      }*/

    



    void Start()
    {
        LoadObtacle();
    }

    void Update()
    {
       // LoadObtacle();
    }

    public void LoadObtacle()
    {
        if (Levels.instance.pickedlevels == "Level1")
        {
            Instantiate(obstacle1, obstacleparent.transform);
        }
        if (Levels.instance.pickedlevels == "Level2")
        {
            Instantiate(obstacle2, obstacleparent.transform);
        }
        if (Levels.instance.pickedlevels == "Level3")
        {
            Instantiate(obstacle3, obstacleparent.transform);
        }
        if (Levels.instance.pickedlevels == "Level4")
        {
            Instantiate(obstacle4, obstacleparent.transform);
        }
        if (Levels.instance.pickedlevels == "Level5")
        {
            Instantiate(obstacle5, obstacleparent.transform);
        }
        if (Levels.instance.pickedlevels == "Level6")
        {
            Instantiate(obstacle6, obstacleparent.transform);
        }
        if (Levels.instance.pickedlevels == "Level7")
        {
            Instantiate(obstacle7, obstacleparent.transform);
        }
        if (Levels.instance.pickedlevels == "Level8")
        {
            Instantiate(obstacle8, obstacleparent.transform);
        }
        if (Levels.instance.pickedlevels == "Level9")
        {
            Instantiate(obstacle9, obstacleparent.transform);
        }

    }

    


}
