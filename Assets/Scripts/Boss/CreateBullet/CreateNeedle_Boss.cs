using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNeedle_Boss : MonoBehaviour
{
    public float wait;
    public GameObject Bullet1;
    public GameObject Bullet2;
    public float a;
    public float x1;
    public float Interval;
    public int loop;
    public AudioClip m_shot;

    AudioSource audioSource;

    private void Start()
    {
        StartCoroutine("Create");
    }

     private IEnumerator Create()
    {
        yield return new WaitForSeconds(wait);

        for(int i = 0; i < loop; i++)
        {

            Vector2 n = this.transform.localPosition;
            Vector3 rota = this.transform.localEulerAngles;
            float r = rota.z;
            n.y += 0.2f;
            float vx = (float)(Mathf.Cos(r * Mathf.Deg2Rad) * 2.4);
            float vy = (float)(Mathf.Sin(r * Mathf.Deg2Rad) * 2.4);
            n.x += vx;
            n.y += vy;
            Instantiate(Bullet1, n,this.transform.rotation);
            float vx2 = (float)(Mathf.Cos((r + 180) * Mathf.Deg2Rad) * 2.4);
            float vy2 = (float)(Mathf.Sin((r + 180) * Mathf.Deg2Rad) * 2.4);
            n.x += vx2 * 2;
            n.y += vy2 * 2;
            Instantiate(Bullet2, n, transform.rotation);
            audioSource = FindObjectOfType<AudioSource>();
            audioSource.PlayOneShot(m_shot);
            yield return new WaitForSeconds(Interval);
        }
    }
}
