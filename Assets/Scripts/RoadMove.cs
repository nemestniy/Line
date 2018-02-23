using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMove : MonoBehaviour {

    
    public Config _config;
    public static float speed;
    public float timer;

    void Start()
    {
        speed = _config.speedOfRoad;
        timer = _config.interval;
    }

    void Update () {
        this.transform.Translate(0, speed * -1, 0);

        if (speed < 0.2)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                speed += 0.001f;
                timer = _config.interval;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Board")
            this.transform.position = _config.StartBoard.position;
    }
}
