using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonManager : MonoBehaviour
{
    public static CannonManager instance;
    // public int id;
    // public LevelDataSO levelData;
    public GameObject cannonparent;
    
    public GameObject cannon;
    

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

    private void Start()
    {
        LoadCannon();
    }

    public void LoadCannon()
    {
        if (Levels.instance.pickedlevels == "Level1")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(1.5f, 2.8f, 0);
        }
        if (Levels.instance.pickedlevels == "Level2")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(1.43f, 2.8f, 0);
        }
        if (Levels.instance.pickedlevels == "Level3")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(1.03f, 3.23f, 0);
            cannonparent.transform.Rotate(0, 0, 21);

        }
        if (Levels.instance.pickedlevels == "Level4")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(1.39f, 1.58f, 0);
            cannonparent.transform.Rotate(0, 0, -39.29f);
        }
        if (Levels.instance.pickedlevels == "Level5")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(1.47f, 2.11f, 0);
        }
        if (Levels.instance.pickedlevels == "Level6")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(1.21f, 3.84f, 0);
        }
        if (Levels.instance.pickedlevels == "Level7")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(-0.1f, 3.47f, 0);
            cannonparent.transform.Rotate(0, 0, 35.99f);
        }
        if (Levels.instance.pickedlevels == "Level8")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(-1.21f, 2.67f, 0);
            cannonparent.transform.Rotate(0, 0, 75.27f);
        }
        if (Levels.instance.pickedlevels == "Level9")
        {
            Instantiate(cannon, cannonparent.transform);
            cannonparent.transform.position = new Vector3(1.43f, 2.5f, 0);
        }
    }
}
