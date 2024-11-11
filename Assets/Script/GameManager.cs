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

    private int currentLevel; // Store the current level
    private const string LevelKey = "currentLevel"; // Key for saving the level

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

    private void Start()
    {
        // Load the level at the start of the game
        LoadLevel();
    }

    public int GetCurrentLevel()
    {
        return currentLevel;
    }

    // Set the current level (usually called when progressing to the next level)
    public void SetCurrentLevel(int level)
    {
        currentLevel = level;
        SaveLevel(); // Optionally, save the current level after updating
    }

    // Increment the current level (when progressing to the next level)
    public void IncrementLevel()
    {
        currentLevel++;
        SaveLevel();
    }

    // Save the current level to PlayerPrefs (so it persists across sessions)
    private void SaveLevel()
    {
        PlayerPrefs.SetInt(LevelKey, currentLevel);
        PlayerPrefs.Save(); // Make sure the data is saved immediately
    }

    // Load the level from PlayerPrefs (loads the saved level when the game starts)
    private void LoadLevel()
    {
        currentLevel = PlayerPrefs.GetInt(LevelKey, 1); // Default to level 1 if not set
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
