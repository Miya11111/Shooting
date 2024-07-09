using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPControl_Enemy : MonoBehaviour
{
    public GameObject explosion;
    public GameObject item;
    public AudioClip m_damage;
    public AudioClip m_explosion;

    AudioSource audioSource;

    bool CalledOnce = false;

    private HPControl_Manager HP1;

    private void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        this.HP1 = FindObjectOfType<HPControl_Manager>();
        
    }

    private void Update()
    {
        if (0 > HP1.HP && !CalledOnce)
        {
            CalledOnce = true;
            StartCoroutine("A");
        }
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("Shot"))
        {
            ScoreCount.score = ScoreCount.score + 10;

            Destroy(collision.gameObject);

            HP1.HP--;

            audioSource.PlayOneShot(m_damage);
        }
    }

    IEnumerator A()
    {
        ScoreCount.score = ScoreCount.score + 1000;

        audioSource.PlayOneShot(m_explosion);

        for (int i = 0; i <= 7; i++)
        {
            Instantiate(explosion, this.transform.position, transform.rotation);
            yield return new WaitForSeconds(0.3f);
        }
        for (int i = 1; i <= 15; i++)
        {
            Instantiate(item, this.transform.position, transform.rotation);
        }
        Destroy(this.gameObject);
    }
}
