using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    public float MoveSpeedy;
    public float MoveSpeedx;
    public float rotateZ;
    public float destroy;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroy);
        Transform rotate = this.transform;
        Vector3 v3 = rotate.eulerAngles;
        v3.z = rotateZ;
        rotate.eulerAngles = v3;
        StartCoroutine("A");
        StartCoroutine("B");

    }



    IEnumerator A()
    {
        for (int i = 0; i < 30; i++)
        {
            this.transform.Translate(0, MoveSpeedy, 0, Space.World);
            yield return new WaitForSeconds(0.17f);
        }
        yield return new WaitForSeconds(14.5f);

        for (int i = 0; i < 30; i++)
        {
            this.transform.Translate(0, -1.5f*MoveSpeedy, 0, Space.World);
            yield return new WaitForSeconds(0.17f);
        }
    }
    IEnumerator B()
    {
        for (int i = 0; i < 5; i++)
        {
            this.transform.Translate(MoveSpeedx, 0, 0);
            yield return new WaitForSeconds(0.13f);
        }
        yield return new WaitForSeconds(0.3f);

        while(true)
        {
            for (int i = 0; i < 10; i++)
            {
                this.transform.Translate(-1 * MoveSpeedx, 0, 0);
                yield return new WaitForSeconds(0.13f);
            }
            yield return new WaitForSeconds(0.3f);

            for (int i = 0; i < 10; i++)
            {
                this.transform.Translate(MoveSpeedx, 0, 0);
                yield return new WaitForSeconds(0.13f);
            }
            yield return new WaitForSeconds(0.3f);
        }

    }
}
