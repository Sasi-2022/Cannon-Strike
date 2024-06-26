using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI counttext;
    public int totalcount;
    public int balls;
    public int lossBalls;
    public int maxProjectiles = 30;
    public int currentProjectiles;
    public TextMeshProUGUI projectileCountText;
    public Button homeBtn;
    public Button homeBtn1;
    public GameObject winningpanel;
    public GameObject losspanel;
    public TextMeshProUGUI loseballs;
    public TextMeshProUGUI loseballs1;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;


    private void OnEnable()
    {
        ProjectileController.ballcollection += BallCount;
        CannonController.text += UpdateProjectileCountUI;
        ProjectileController.lossballCount += LossBallCount;
    }

    private void OnDisable()
    {
        ProjectileController.ballcollection -= BallCount;
        CannonController.text -= UpdateProjectileCountUI;
        ProjectileController.lossballCount -= LossBallCount;
    }

    void Start()
    {

        homeBtn1.onClick.AddListener(OnclickHomeBtn);
        homeBtn.onClick.AddListener(OnclickBtn);
        currentProjectiles = maxProjectiles;
        projectileCountText.text = maxProjectiles.ToString();
        //  UpdateProjectileCountUI();


    }

    void Update()
    {
        WinningPanel();
        LossPanel();
    }

    public void BallCount()
    {
        Debug.Log("count");
        balls++;
        counttext.text = $"{balls.ToString()}/{ totalcount.ToString()}";
    }

    void OnclickBtn()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level Map Scene");
    }
    void OnclickHomeBtn()
    {
        SceneManager.LoadScene("Level Map Scene");
        Debug.Log("stop");
        //Time.timeScale = 1f;
    }

    void UpdateProjectileCountUI()
    {
        currentProjectiles--;
        projectileCountText.text = currentProjectiles.ToString();
    }

    public void WinningPanel()
    {
        if (balls == totalcount)
        {
            Time.timeScale = 0f;
            winningpanel.SetActive(true);
            losspanel.SetActive(false);
            //var losball = maxProjectiles - balls - currentProjectiles;
           // loseballs.text = $"LoseBalls : {loseball.ToString()}";
            if (lossBalls == 0)
            {
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
            }
            else if (lossBalls < 10 && lossBalls != 0)
            {
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(false);
            }
            else if (lossBalls > 10 || lossBalls == 10)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(false);
            }

        }
    }

    public void LossPanel()
    {
        if (balls < totalcount && currentProjectiles == 0)
        {
            Time.timeScale = 0f;
            losspanel.SetActive(true);
            winningpanel.SetActive(false);
           // var loseball = maxProjectiles - balls - currentProjectiles;
           // loseballs1.text = $"LoseBalls : {loseball.ToString()}";
        }
    }


    /* public void DisplayStar()
     {
         var loseball = maxProjectiles - balls - currentProjectiles;
         if (loseball== 0)
         {
             star1.SetActive(true);
             star2.SetActive(true);
             star3.SetActive(true);
         }
         if(loseball < 10 && loseball != 0)
         {
             star1.SetActive(true);
             star2.SetActive(true);
             star3.SetActive(false);
         }
         if (loseball >10)
         {
             star1.SetActive(false);
             star2.SetActive(false);
             star3.SetActive(false);
         }
     }*/


    public void LossBallCount()
    {
        lossBalls++;
        loseballs.text = $"LoseBalls : {lossBalls.ToString()}";
        loseballs1.text = $"LoseBalls : {lossBalls.ToString()}";
    }
}
