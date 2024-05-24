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
    public int maxProjectiles = 30;
    private int currentProjectiles;
    public Text projectileCountText;
    public Button homeBtn;

    private void OnEnable()
    {
        ProjectileController.ballcollection += BallCount;
        CannonController.text += UpdateProjectileCountUI;
    }

    private void OnDisable()
    {
        ProjectileController.ballcollection -= BallCount;
        CannonController.text -= UpdateProjectileCountUI;
    }

    void Start()
    {
        homeBtn.onClick.AddListener(OnclickBtn);
        currentProjectiles = maxProjectiles;
        UpdateProjectileCountUI();
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

    void UpdateProjectileCountUI()
    {
        projectileCountText.text = currentProjectiles.ToString();
    }
}
