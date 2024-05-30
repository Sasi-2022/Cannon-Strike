using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinManager : MonoBehaviour
{
    public static WinManager instance;
    public GameObject winPanel;
    public GameObject losePanel;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

}
