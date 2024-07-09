using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreCountHard : MonoBehaviour
{
    private int highscore;
    private string key = "HIGHSCORE+";
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt(key, 0);
        GetComponent<Text>().text = highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreCount.score > highscore)
        {
            highscore = ScoreCount.score;
            PlayerPrefs.SetInt(key, highscore);
            GetComponent<Text>().text = highscore.ToString();
        }
    }
}
