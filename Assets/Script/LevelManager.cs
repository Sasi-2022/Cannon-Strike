using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public LevelDataSO levelData;
    public GameObject levelitem;
    public GameObject levelcontainer;

    // Start is called before the first frame update
    void Start()
    {
        LoadLevels();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevels()
    {
        levelData.levels.ForEach((e) =>
        {
            var a = Instantiate(levelitem, levelcontainer.transform);
            var b = a.GetComponent<LevelsHandler>();
            b.id = e.Id;
            b.leveltext.text = e.LevelsNo;

        });
    }
}
