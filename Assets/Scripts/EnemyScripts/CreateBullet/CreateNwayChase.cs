using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNwayChase : MonoBehaviour
{
    public GameObject Bullet;
    public float Interval;
    public int WayNumber;
    public float FirstAngle;
    public float Angle;
    public GameObject Player;
    public AudioClip m_shot;

    AudioSource audioSource;

    private void Start()
    {
        Player = GameObject.Find("Player");
        StartCoroutine("Create");
    }

    private void FixedUpdate()
    {
        Vector3 vec3 = (Player.gameObject.transform.position - this.transform.position);
        this.transform.rotation = Quaternion.FromToRotation(Vector3.up, -vec3);
    }

    private IEnumerator Create()
    {
        while (true)
        {
            for(int i = 1;i <= WayNumber; i++)
            {
                Instantiate(Bullet, transform.position, transform.rotation * Quaternion.Euler(0, 0, FirstAngle));
                audioSource = FindObjectOfType<AudioSource>();
                audioSource.PlayOneShot(m_shot);
                FirstAngle += Angle;
            }
            FirstAngle += -Angle * WayNumber;
            yield return new WaitForSeconds(Interval);
        }
    }
}
