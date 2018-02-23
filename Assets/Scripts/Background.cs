using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public Camera cam;
    public Config _config;
    public float timer;

    void Start()
    {
        timer = _config.interval;   
    }

    void Update()
    {
        if(cam.backgroundColor.g > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                cam.backgroundColor = new Color(cam.backgroundColor.r, cam.backgroundColor.g - .001f, cam.backgroundColor.b - .001f);
                timer = _config.interval;
            }
        }
    }

}
