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
        pickedlevels = "Level1";
        SceneManager.LoadScene(2);
       //level1.Invoke();
    }

    public void btn_level2()
    {
        pickedlevels = "Level2";
        SceneManager.LoadScene(2);
       // level2.Invoke();
    }

    public void btn_level3()
    {
        pickedlevels = "Level3";
        SceneManager.LoadScene(2);
        //level3.Invoke();
    }

    public void btn_level4()
    {
        pickedlevels = "Level4";
        SceneManager.LoadScene(2);
        //level4.Invoke();
    }

    public void btn_level5()
    {
        pickedlevels = "Level5";
        SceneManager.LoadScene(2);
        //level4.Invoke();
    }

    public void btn_level6()
    {
        pickedlevels = "Level6";
        SceneManager.LoadScene(2);
        //level4.Invoke();
    }

    public void btn_level7()
    {
        pickedlevels = "Level7";
        SceneManager.LoadScene(2);
        //level4.Invoke();
    }

    public void btn_level8()
    {
        pickedlevels = "Level8";
        SceneManager.LoadScene(2);
        //level4.Invoke();
    }
    public void btn_level9()
    {
        pickedlevels = "Level9";
        SceneManager.LoadScene(2);
        //level4.Invoke();
    }
}
