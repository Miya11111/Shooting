using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private float time = 0;
    public GameObject A;
    public GameObject B;
    public float n1;
    public float n2;
    // Start is called before the first frame update
    void Start()
    {
        A.gameObject.SetActive(false);
        B.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;

        if(time >= n1)
        {
            A.gameObject.SetActive(true);
        }

        if (time >= n2)
        {
            B.gameObject.SetActive(true);
        }
    }
}
