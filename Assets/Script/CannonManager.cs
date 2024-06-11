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
    public GameObject[] levelImage;



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
            //levelTxt.text = "LEVEL : " + 1;
            levelImage[0].SetActive(true);
        }
        if (Levels.instance.pickedlevels == "Level2")
        {
            Instantiate(cannon, cannonparent.transform);
            // cannonparent.transform.position = new Vector3(1.43f, 2.8f, 0);
            levelImage[1].SetActive(true);

        }
        if (Levels.instance.pickedlevels == "Level3")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(-0.4f, 3.23f, 0);
            cannonparent.transform.Rotate(0, 0, 50);
            levelImage[2].SetActive(true);

        }
        if (Levels.instance.pickedlevels == "Level4")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(-0.1f, 1.8f, 0);
            cannonparent.transform.Rotate(0, 0, -39.29f);
            levelImage[3].SetActive(true);

        }
        if (Levels.instance.pickedlevels == "Level5")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(0.1f, 2.11f, 0);
            levelImage[4].SetActive(true);

        }
        if (Levels.instance.pickedlevels == "Level6")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(0.2f, 3.0f, 0);
            levelImage[5].SetActive(true);

        }
        if (Levels.instance.pickedlevels == "Level7")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(-0.1f, 3.47f, 0);
            // cannonparent.transform.Rotate(0, 0, 35.99f);
            levelImage[6].SetActive(true);

        }
        if (Levels.instance.pickedlevels == "Level8")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(-1.3f, 1f, 0);
            cannonparent.transform.Rotate(0, 0, 90f);
            levelImage[7].SetActive(true);

        }
        if (Levels.instance.pickedlevels == "Level9")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(0.1f, 1.5f, 0);
            levelImage[8].SetActive(true);

        }

    }
        public void OnClickHomeBtn()
        {
            SceneManager.LoadScene("Level Map Scene");
        }
}
