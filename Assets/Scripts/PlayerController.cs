using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public Config _config;
    private bool approve;
    public static bool RestartSpeed = false;
    public Text TouchThis;

    private void OnMouseDown()
    {
        approve = true;
        TouchThis.enabled = false;
    }

    private void OnMouseUp()
    {
        approve = false;
    }

    void Update()
    {
        if (approve)
        {
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, this.transform.position.z);
            position = Camera.main.ScreenToWorldPoint(position);
            this.transform.position = Vector3.Lerp(transform.position, position, _config.speedOfMoving * Time.deltaTime);
        }

        if (PlayerPrefs.GetInt("Record") > 0)
        {
            MaxScore.txt.text = PlayerPrefs.GetInt("Record").ToString();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            MaxScore.ChangeScore(BroadcastInfo.score);
            BroadcastInfo.score = 0;
            RoadMove.speed = _config.speedOfRoad;
        }
    }
}
