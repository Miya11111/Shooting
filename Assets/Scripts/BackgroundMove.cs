using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    float speed = 1f;
    public float Timeup;

    private float time; 

    void Update()
    {
        time += Time.deltaTime;
        if(time > Timeup)
        {
            speed = 0;
        }

        transform.position -= new Vector3(0, Time.deltaTime * speed);
        if (transform.position.y <= -20.5f)
        {
            transform.position = new Vector3(-2.0f, 20.5f,10f);
        }
    }

}
