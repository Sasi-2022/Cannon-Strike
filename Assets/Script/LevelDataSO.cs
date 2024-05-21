using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "LevelData", menuName = "Assets/LevelData")]
public class LevelDataSO : ScriptableObject
{
    public List<Level> levels;
}

[Serializable]
public class Level
{
    public int Id;
    public string LevelsNo;
    
}
