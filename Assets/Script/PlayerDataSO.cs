using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[CreateAssetMenu(fileName = "PlayerdataSO", menuName = "Assets/PlayerSO")]
public class PlayerDataSO : ScriptableObject
{
    public Player player;

    void Reset()
    {
        Debug.Log("Reset");
    }
}
