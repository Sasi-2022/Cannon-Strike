using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI counttext;
    public int totalcount;
    public int balls;

    private void OnEnable()
    {
        ProjectileController.ballcollection += BallCount;
    }

    private void OnDisable()
    {
        ProjectileController.ballcollection -= BallCount;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BallCount()
    {
        balls++;
        counttext.text= $"{balls.ToString()}/:{ totalcount.ToString()}";
    }
}
