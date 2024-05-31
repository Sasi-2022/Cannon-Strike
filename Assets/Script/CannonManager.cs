using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CannonManager : MonoBehaviour
{
    // public int id;
    // public LevelDataSO levelData;
    public GameObject cannonparent;
    
    public GameObject cannon;
    public Text levelTxt;
    public Button homeBtn;



    private void Start()
    {
        LoadCannon();
        homeBtn.onClick.AddListener(OnClickHomeBtn);

    }
    private void Update()
    {
      //  LoadCannon();
    }

    public void LoadCannon()
    {
        if (Levels.instance.pickedlevels == "Level1")
        {
            Instantiate(cannon, cannonparent.transform);
            //cannonparent.transform.position = new Vector3(53f, 2.8f, 0);
            levelTxt.text = "LEVEL : " + 1;

        }
        if (Levels.instance.pickedlevels == "Level2")
        {
            Instantiate(cannon, cannonparent.transform);
           // cannonparent.transform.position = new Vector3(1.43f, 2.8f, 0);
            levelTxt.text = "LEVEL : " + 2;

        }
        if (Levels.instance.pickedlevels == "Level3")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(0.5f, 3.23f, 0);
            cannonparent.transform.Rotate(0, 0, 21);
            levelTxt.text = "LEVEL : " + 3;

        }
        if (Levels.instance.pickedlevels == "Level4")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(0.5f, 1.52f, 0);
            cannonparent.transform.Rotate(0, 0, -39.29f);
            levelTxt.text = "LEVEL : " + 4;

        }
        if (Levels.instance.pickedlevels == "Level5")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(0.5f, 2.11f, 0);
            levelTxt.text = "LEVEL : " + 5;

        }
        if (Levels.instance.pickedlevels == "Level6")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(0.2f, 3.0f, 0);
            levelTxt.text = "LEVEL : " + 6;

        }
        if (Levels.instance.pickedlevels == "Level7")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(-0.1f, 3.47f, 0);
           // cannonparent.transform.Rotate(0, 0, 35.99f);
            levelTxt.text = "LEVEL : " + 7;

        }
        if (Levels.instance.pickedlevels == "Level8")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(0.5f, 2.67f, 0);
           // cannonparent.transform.Rotate(0, 0, 75.27f);
            levelTxt.text = "LEVEL : " + 8;

        }
        if (Levels.instance.pickedlevels == "Level9")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(0.5f, 2.5f, 0);
            levelTxt.text = "LEVEL : " + 9;

        }

    }
        public void OnClickHomeBtn()
        {
            SceneManager.LoadScene("Level Map Scene");
        }
}
