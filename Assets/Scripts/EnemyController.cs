using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public GameObject player;

    private bool generate;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        generate = true;
    }

    private void Update()
    {
        this.transform.Translate(0, RoadMove.speed * -1, 0);
        if (this.transform.position.y < player.transform.position.y)
        {
            IncreaseScore(generate);
            generate = false;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Board")
            Destroy(gameObject);
    }

    private void IncreaseScore(bool generate)
    {
        if (generate)
        {
            BroadcastInfo.score++;
        }
        return;
    }
}
