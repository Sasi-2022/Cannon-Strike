using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int collectedCount = 0;
    public Text collectedCountText;

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
