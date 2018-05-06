using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour {

    public GameObject Enemy;

    public Config _config;
    public float timer;

	// Use this for initialization
	void Start () {
        timer = _config.interval;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime * (BroadcastInfo.score + 1) * .5f;
        if(timer <= 0)
        {
            Enemy.transform.position = getPosition();
            Enemy.transform.localScale = getScale();
            Instantiate(Enemy);
            timer = _config.interval + BroadcastInfo.score;
        }
	}

    static Vector3 getPosition()
    {
        float posX = Random.Range(-3f, 3f);
        return new Vector3(posX, 6, 3);

    }

    static Vector3 getScale()
    {
        float scale = Random.Range(.45f, .7f);
        return new Vector3(scale, scale, 1);
    }
}
