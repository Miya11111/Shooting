using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNway : MonoBehaviour
{
    public GameObject Bullet;
    public float Interval;
    public int WayNumber;
    public float FirstAngle;
    public float Angle;

    private void Start()
    {
        StartCoroutine("Create");
    }

     private IEnumerator Create()
    {
        while (true)
        {
            for(int i = 1;i <= WayNumber; i++)
            {
                Instantiate(Bullet, transform.position, transform.rotation * Quaternion.Euler(0, 0, FirstAngle));
                FirstAngle += Angle;
            }
            FirstAngle += -Angle * WayNumber;
            yield return new WaitForSeconds(Interval);
        }
    }
}
