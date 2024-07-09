using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grasshopper : MonoBehaviour
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

    private float time = 0f;
    private int hp;
    private void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        hp = Maxhp;
        Destroy(gameObject, destroy);

    }

    private void FixedUpdate()
    {
        time += Time.deltaTime;

        if (time > 0f && time < 1f)
        {
            
            Vector2 v2 = new Vector2(0.2f, 0.8f);
            Vector2 v1 = new Vector2(-0.15f, 0f);
            BoxCollider2D collider = GetComponent<BoxCollider2D>();
            collider.size = v2;
            collider.offset = v1;
            this.transform.Translate(0f, -0.02f, 0);
        }

        if (time > 1f && time < 2f)
        {
            Vector2 v2 = new Vector2(0.7f, 0.5f);
            BoxCollider2D collider = GetComponent<BoxCollider2D>();
            collider.size = v2;
            this.transform.Translate(0.09f, -0.03f, 0);
        }


        if (time > 2f && time < 3f)
        {
            
            Vector2 v2 = new Vector2(0.2f, 0.8f);
            Vector2 v1 = new Vector2(0.15f, 0f);
            BoxCollider2D collider = GetComponent<BoxCollider2D>();
            collider.size = v2;
            collider.offset = v1;
            this.transform.Translate(0f, -0.02f, 0);
        }

        if (time > 3f && time < 4f)
        {
            Vector2 v2 = new Vector2(0.7f, 0.5f);
            BoxCollider2D collider = GetComponent<BoxCollider2D>();
            collider.size = v2;
            this.transform.Translate(-0.09f, -0.03f, 0);
        }

        if (time > 4f)
        {
            time = 0;
        }

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
