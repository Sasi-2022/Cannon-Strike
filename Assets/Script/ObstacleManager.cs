using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ObstacleManager : MonoBehaviour
{
   public static ObstacleManager instance;
   // public int id;
   // public LevelDataSO levelData;
    public GameObject obstacleparent;
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;



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

    private void Awake()
    {
        {
            if (instance == null)
            {
                DontDestroyOnLoad(gameObject);
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(gameObject);
            }
        }
    }



    void Start()
    {
        LoadObtacle();
    }

    // Update is called once per frame
    void Update()
    {
        
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

    }

    


}
