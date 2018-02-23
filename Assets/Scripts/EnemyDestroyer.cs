using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour {

    private void Update()
    {
        this.transform.Translate(0, RoadMove.speed * -1, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Board")
            Destroy(gameObject);
    }
}
