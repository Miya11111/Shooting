using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossM_Manager : MonoBehaviour
{
    public float time = 1f;
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject slider;
    public GameObject sliderM;
    public float n1;
    public float n2;
    public float n3;
    public float n4;
    public float n5;


    // Start is called before the first frame update
    void Start()
    {
        A.gameObject.SetActive(false);
        B.gameObject.SetActive(false);
        C.gameObject.SetActive(false);
        D.gameObject.SetActive(false);
        slider.gameObject.SetActive(false);
        sliderM.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;

        if(time >= n1)
        {
            slider.gameObject.SetActive(true);
            sliderM.gameObject.SetActive(true);
            A.gameObject.SetActive(true);
        }

        if (time >= n2)
        {
            B.gameObject.SetActive(true);
        }

        if (time >= n3)
        {
            C.gameObject.SetActive(true);
        }

        if (time >= n4)
        {
            D.gameObject.SetActive(true);
        }

        if(time >= n5)
        {
            A.gameObject.SetActive(false);
            B.gameObject.SetActive(false);
            C.gameObject.SetActive(false);
            D.gameObject.SetActive(false);
            time = n1;
        }
    }
}
