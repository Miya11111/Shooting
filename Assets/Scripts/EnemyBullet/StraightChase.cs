using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightChase : MonoBehaviour
{
    public float speed;
    public float destroy;
    public GameObject Player;

    private void Start()
    {
        Destroy(gameObject, destroy);
        Player = GameObject.Find("Player");

        Vector3 vec3 = Player.gameObject.transform.position - this.transform.position;
        this.transform.rotation = Quaternion.FromToRotation(Vector3.up, vec3);

    }

    private void FixedUpdate()
    {
        this.transform.Translate(0, 0.05f * speed, 0);
    }
}
