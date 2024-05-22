using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelsHandler : MonoBehaviour
{
    public int id;
    public TextMeshProUGUI leveltext;
    public Button startbtn;

    public void Start()
    {
        startbtn.onClick.AddListener(OnclickLevel);
    }

    public void OnclickLevel()
    {
        SceneManager.LoadScene(2);
    }
}
