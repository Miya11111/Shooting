using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    Button button;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape") && PlayerControl.GameoverOrNot == false)
        {
            button = GameObject.Find("Canvas/Pause/ButtonSummary/CONTINUE").GetComponent<Button>();
            button.Select();
        }
    }
}
