using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningPanelController : MonoBehaviour
{
    void OnEnable()
    {
        // Pause the game when the winning panel is enabled
        Time.timeScale = 0;
    }

    void OnDisable()
    {
        // Resume the game when the winning panel is disabled
        Time.timeScale = 1;
    }
}
