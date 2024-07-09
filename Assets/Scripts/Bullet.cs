using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int speed = 5;

    void Start()
    {
        Destroy(gameObject, 2f);
    }
    private void FixedUpdate()
    {
        this.transform.Translate(0, 0.01f * speed, 0);
    }
}
