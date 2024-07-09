using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject warning;
    void Start()
    {
        StartCoroutine("B");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator B()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(warning, new Vector3(-2, -4, 0), Quaternion.identity);
            yield return new WaitForSeconds(0.2f);
        }
    }
}
