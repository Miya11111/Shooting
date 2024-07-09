using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePause : MonoBehaviour
{
    public GameObject pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnPressZPause()
    {
        Time.timeScale = 1;
        pause.gameObject.SetActive(false);
    }
}
