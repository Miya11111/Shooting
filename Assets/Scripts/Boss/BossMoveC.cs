using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMoveC : MonoBehaviour
{
    public float MoveSpeedy;
    public float rotateZ;
    public float destroy;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroy);
        StartCoroutine("A");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(0, 0.01f*MoveSpeedy, 0);
    }
    IEnumerator A()
    {
        for (int i = 0; i < 15; i++)
        {
            Transform rotate = this.transform;
            Vector3 v3 = rotate.eulerAngles;
            v3.z += rotateZ;
            rotate.eulerAngles = v3;
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(0.2f);

        while (true)
        {
            for (int i = 0; i < 30; i++)
            {
                Transform rotate = this.transform;
                Vector3 v3 = rotate.eulerAngles;
                v3.z += -1 * rotateZ;
                rotate.eulerAngles = v3;
                yield return new WaitForSeconds(0.1f);
            }

            yield return new WaitForSeconds(0.2f);

            for (int i = 0; i < 30; i++)
            {
                Transform rotate = this.transform;
                Vector3 v3 = rotate.eulerAngles;
                v3.z += rotateZ;
                rotate.eulerAngles = v3;
                yield return new WaitForSeconds(0.1f);
            }

            yield return new WaitForSeconds(0.2f);
        }
    }
}
