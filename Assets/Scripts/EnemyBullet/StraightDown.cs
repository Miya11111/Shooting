using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightDown : MonoBehaviour
{
    public float speed;
    public float destroy;
    public float down_rotate;
    public float rotation;

    private void Start()
    {
        Destroy(gameObject,destroy);

        Transform rotate = this.transform;
        Vector3 v3 = rotate.eulerAngles;
        v3.z += rotation;
        rotate.eulerAngles = v3;
    }

    private void FixedUpdate()
    {
        this.transform.Translate(0, -0.05f * speed, 0);
        Vector3 v3 = this.transform.eulerAngles;
        v3.z += -0.1f * down_rotate;
        this.transform.eulerAngles = v3;
    }
}
