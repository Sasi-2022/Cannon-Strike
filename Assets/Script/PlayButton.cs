using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public Button playBtn;
    void Start()
    {
        playBtn.onClick.AddListener(LoadScene);
    }

    void Update()
    {
        
    }

    void LoadScene()
    {
        SceneManager.LoadScene(2);
    }
}
