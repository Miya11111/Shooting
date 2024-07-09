using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownWalk : MonoBehaviour
{
    public float speed;
    public int Maxhp;
    public float destroy;
    public GameObject item;
    public int HowManyItems;
    public GameObject explosion;
    public int Score;
    public AudioClip m_damage;

    AudioSource audioSource;

    private int hp;
    private void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        hp = Maxhp;
        Destroy(gameObject, destroy);
    }

    private void FixedUpdate()
    {
        this.transform.Translate(0, -0.01f*speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("Shot"))
        {
            ScoreCount.score = ScoreCount.score + 10;

            Destroy(collision.gameObject);

            hp--;

            audioSource.PlayOneShot(m_damage);

            if (0 < hp) return;

            ScoreCount.score = ScoreCount.score + Score;

            Destroy(gameObject);
            Instantiate(explosion, this.transform.position, transform.rotation);

            for (int i = 1; i <= HowManyItems; i++)
            {
                Instantiate(item,this.transform.position,transform.rotation);
            }
        }
    }
}
