using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppearAndDisappear : MonoBehaviour
{
    public Text text;
    private float u = 1;
    public float n;
    public float remain;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("A");
    }

    // Update is called once per frame
    void Update()
    {
        text.color = new Color(255, 255, 255, u);
    }

    private IEnumerator A()
    {
        

        while(true)
        {
            yield return new WaitForSeconds(remain *2);

            for (int i = 1; i < 10; i++)
            {
                u -= n;

                yield return new WaitForSeconds(0.1f);
            }

            yield return new WaitForSeconds(remain);

            for (int i = 1; i < 10; i++)
            {
                u += n;

                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}
