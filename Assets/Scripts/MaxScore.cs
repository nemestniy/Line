using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxScore : MonoBehaviour {

    public static Text txt;
    private static int deltaScore;

    void Start()
    {
        txt = GetComponent<Text>();
        deltaScore = PlayerPrefs.GetInt("Record");
    }

    public static void ChangeScore(int score)
    {
        if (deltaScore < score)
        {
            deltaScore = score;
            txt.text = score.ToString();
            PlayerPrefs.SetInt("Record", score);
            PlayerPrefs.Save();
        }
    }

}
