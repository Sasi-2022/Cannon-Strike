using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Home : MonoBehaviour
{
    public Button homeBtn;
    void Start()
    {
        homeBtn.onClick.AddListener(LoadScene);
    }

    void Update()
    {

    }

    void LoadScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
