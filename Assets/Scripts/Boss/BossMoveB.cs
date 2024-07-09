using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMoveB : MonoBehaviour
{
    public float Time1;
    public float Time2;
    private float time = 0;
    public float destroy;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroy);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time > 0)
        {
            this.transform.Translate(0, -0.07f, 0);
        }

        if (time > Time1 && time < Time2)
        {
            Transform rotate = this.transform;
            Vector3 v3 = rotate.eulerAngles;
            v3.z += -4;
            rotate.eulerAngles = v3;
        }

        if (time > Time2)
        {
            this.transform.Translate(0, 0.02f, 0);
        }

        if (time > Time2 + 5)
        {
            Destroy(this.gameObject);
        }
    }
}
