using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int collectedCount = 0;
    public TextMeshProUGUI collectedCountText;
    public GameObject box;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void IncreaseCollectedCount()
    {
        collectedCount++;
        UpdateCollectedCountUI();
    }

    void UpdateCollectedCountUI()
    {
        collectedCountText.text = "Collected: " + collectedCount;
    }
}
