using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Levels : MonoBehaviour
{
    public static Levels instance;
    [HideInInspector]
    public string pickedlevels;

   // public static Action level1;
   // public static Action level2;
    //public static Action level3;
    //public static Action level4;


    private void Awake()
    {
        
            
            instance = this;
        


    }

    public void btn_level1()
    {
        Time.timeScale = 1f;
        pickedlevels = "Level1";
        SceneManager.LoadScene(2);
       //level1.Invoke();
    }

    public void btn_level2()
    {
        Time.timeScale = 1f;
        pickedlevels = "Level2";
        SceneManager.LoadScene(2);
       // level2.Invoke();
    }

    public void btn_level3()
    {
        Time.timeScale = 1f;
        pickedlevels = "Level3";
        SceneManager.LoadScene(2);
        //level3.Invoke();
    }

    public void btn_level4()
    {
        Time.timeScale = 1f;
        pickedlevels = "Level4";
        SceneManager.LoadScene(2);
        //level4.Invoke();
    }

    public void btn_level5()
    {
        Time.timeScale = 1f;
        pickedlevels = "Level5";
        SceneManager.LoadScene(2);
        //level4.Invoke();
    }

    public void btn_level6()
    {
        Time.timeScale = 1f;
        pickedlevels = "Level6";
        SceneManager.LoadScene(2);
        //level4.Invoke();
    }

    public void btn_level7()
    {
        Time.timeScale = 1f;
        pickedlevels = "Level7";
        SceneManager.LoadScene(2);
        //level4.Invoke();
    }

    public void btn_level8()
    {
        Time.timeScale = 1f;
        pickedlevels = "Level8";
        SceneManager.LoadScene(2);
        //level4.Invoke();
    }
    public void btn_level9()
    {
        Time.timeScale = 1f;
        pickedlevels = "Level9";
        SceneManager.LoadScene(2);
        //level4.Invoke();
    }
}
