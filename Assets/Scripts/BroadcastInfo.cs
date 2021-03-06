﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BroadcastInfo : MonoBehaviour {

    public Config _config;
    public static int score;
    public static float k;
    private Text txt;
    private float timer;

    void Start()
    {
        txt = GetComponent<Text>();
        timer = _config.interval;
        score = 0;
    }

    void Update()
    {
        k = 1;
        txt.text = score.ToString();
        timer -= Time.deltaTime * k * 2;
        if(timer <= 0)
        {
            timer = _config.interval;
        }
        k += 0.01f;
    }



}
