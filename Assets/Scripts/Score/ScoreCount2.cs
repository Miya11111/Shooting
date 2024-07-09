using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCount2 : MonoBehaviour
{
    public string sceneName = "";
    public float n;

    private float time;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        time += Time.unscaledDeltaTime;

        if (time > n)
        {
            SceneManager.LoadScene(sceneName);
        }

        GetComponent<Text>().text = ScoreCount.score.ToString();
        
    }
}
