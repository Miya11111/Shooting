using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public string sceneName = "";

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnPressZStartButton()
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
    }
}
