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
    public Button homeBtn;

    private void OnEnable()
    {
        ProjectileController.ballcollection += BallCount;
    }

    private void OnDisable()
    {
        ProjectileController.ballcollection -= BallCount;
    }

    void Start()
    {
        homeBtn.onClick.AddListener(OnclickBtn);
    }

    void Update()
    {
        
    }

    public void BallCount()
    {
        balls++;
        counttext.text= $"{balls.ToString()}/{ totalcount.ToString()}";
    }

    void OnclickBtn()
    {
        SceneManager.LoadScene("Level Map Scene");
    }
}
