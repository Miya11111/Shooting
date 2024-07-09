using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 3;
    public float slowspeed = 150; //大きいほど遅い
    public string slowAnime = "";
    public string quickAnime = "";
    public string reviveAnime = "";
    public GameObject bullet;
    public GameObject bullet2;
    public GameObject bomb;
    public GameObject bomb2;
    public Pichuuun explosionprefab;
    public GameObject gameover;
    public GameObject S1;
    public GameObject S2;
    bool flag = false;
    bool ShotOrNot = true;
    bool BombOrNot = true;
    public static bool Cdetection = true;
    public static bool GameoverOrNot = false;

    public AudioClip m_shot1;
    public AudioClip m_shot2;
    public AudioClip m_bomb1;
    public AudioClip m_bomb2;
    public AudioClip m_pichun;
    public AudioClip m_revive;
    AudioSource audioSource;

    private float timeBetweenShot = 0.3f;
    private float timer;
    private float bombTimer = 20f;
    [SerializeField]

    string nowMode = "";


    float vx = 0;
    float vy = 0;

    private void Start()
    {
        GameoverOrNot = false;
        Cdetection = true;
        audioSource = FindObjectOfType<AudioSource>();
    }
    private void Update()
    {
        vx = 0;
        vy = 0;
        if(Input.GetKey("right"))
        {
            vx = speed;
        }
        if (Input.GetKey("left"))
        {
            vx = -speed;
        }
        if (Input.GetKey("up"))
        {
            vy = speed;
        }
        if (Input.GetKey("down"))
        {
            vy = -speed;
        }
        timer += Time.deltaTime;

        if (Input.GetKey("z") && timer > timeBetweenShot && ShotOrNot == true)
        {
            timer = 0.0f;
            if (Input.GetKey("left shift"))
             {
                timer = 0.25f;
                
                Instantiate(bullet, transform.position, transform.rotation);

                audioSource.PlayOneShot(m_shot1);
            }
            else 
            {
                Instantiate(bullet2, transform.position, transform.rotation);
                Instantiate(bullet2, transform.position, transform.rotation * Quaternion.Euler(0, 0, 20));
                Instantiate(bullet2, transform.position, transform.rotation * Quaternion.Euler(0, 0, -20));
                Instantiate(bullet2, transform.position, transform.rotation * Quaternion.Euler(0, 0, 40));
                Instantiate(bullet2, transform.position, transform.rotation * Quaternion.Euler(0, 0, -40));

                audioSource.PlayOneShot(m_shot2);
            }

        }
        
        bombTimer += Time.deltaTime;

        if(Input.GetKey("x") && bombTimer > 1f && PointCounter.point >= 25 && BombOrNot == true)
        {
            bombTimer = 0.0f;
            if(Input.GetKey("left shift"))
            {
                audioSource.PlayOneShot(m_bomb1);
                StartCoroutine("B1");

            }
            else
            {
                audioSource.PlayOneShot(m_bomb2);
                StartCoroutine("B2");
            }
            PointCounter.point = PointCounter.point - 25;
        }
    }
    void FixedUpdate()
    {

        if (Input.GetKey("left shift"))
        {
            this.transform.Translate(vx / slowspeed, vy / slowspeed, 0);
            nowMode = slowAnime;
        }
        else
        {
            this.transform.Translate(vx / 50, vy / 50, 0);
            nowMode = quickAnime;
        }

        if (flag == true)
        {
            nowMode = reviveAnime;
            
        }

            this.GetComponent<Animator>().Play(nowMode);
        transform.localPosition = Utils.ClampPosition(transform.localPosition);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("Enemy") && Cdetection == true  || collision.name.Contains("bullet") && Cdetection == true)
        {
            Instantiate(explosionprefab, transform.position, Quaternion.identity);

            audioSource.PlayOneShot(m_pichun);

            if (PointCounter.point >= 100)
            {

                StartCoroutine("N");
            }

            else
            {
                Time.timeScale = 0;
                gameover.SetActive(true);
                gameObject.SetActive(false);
                GameoverOrNot = true;
            }
        }
    }
    IEnumerator B1()
    {
        Cdetection = false;
        ShotOrNot = false;
        BombOrNot = false;
        this.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.5f);

        for (int i = 0; i < 100; i++)
        {
            Instantiate(bomb, transform.position, transform.rotation);

            yield return new WaitForSeconds(0.03f);
        }

        ShotOrNot = true;
        for (int i = 0; i < 10; i++)
        {
            this.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 1f);

            yield return new WaitForSeconds(0.1f);

            this.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.01f);

            yield return new WaitForSeconds(0.1f);
        }
        Cdetection = true;
        BombOrNot = true;
        this.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 1f);
    }
    
    IEnumerator B2()
    {
        Cdetection = false;
        ShotOrNot = false;
        BombOrNot = false;
        this.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.5f);

        for (int i = 0; i < 12; i++)
        {
            Instantiate(bomb2, transform.position, transform.rotation);
            Instantiate(bomb2, transform.position, transform.rotation * Quaternion.Euler(0, 0, 20));
            Instantiate(bomb2, transform.position, transform.rotation * Quaternion.Euler(0, 0, -20));
            Instantiate(bomb2, transform.position, transform.rotation * Quaternion.Euler(0, 0, 40));
            Instantiate(bomb2, transform.position, transform.rotation * Quaternion.Euler(0, 0, -40));
            Instantiate(bomb2, transform.position, transform.rotation * Quaternion.Euler(0, 0, 60));
            Instantiate(bomb2, transform.position, transform.rotation * Quaternion.Euler(0, 0, -60));
            Instantiate(bomb2, transform.position, transform.rotation * Quaternion.Euler(0, 0, 80));
            Instantiate(bomb2, transform.position, transform.rotation * Quaternion.Euler(0, 0, -80));
            yield return new WaitForSeconds(0.5f);
        }

        ShotOrNot = true;

        for (int i = 0; i < 10; i++)
        {
            this.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 1f);

            yield return new WaitForSeconds(0.1f);

            this.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.01f);

            yield return new WaitForSeconds(0.1f);
        }
        Cdetection = true;
        BombOrNot = true;
        this.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 1f);
    }
    IEnumerator N()
    {
        Cdetection = false;

        PointCounter.point = PointCounter.point - 100;

        Transform mytransform = this.transform;
        Vector2 vec2 = mytransform.position;
        vec2.x = -2;
        vec2.y = -4;
        mytransform.position = vec2;

        audioSource.PlayOneShot(m_revive);

        flag = true;
        speed = 0;

        yield return new WaitForSeconds(0.7f);

        flag = false;
        speed = 4;

        for (int i = 1; i < 15; i++)
        {
            this.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.01f);

            yield return new WaitForSeconds(0.05f);

            this.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 1f);

            yield return new WaitForSeconds(0.05f);
        }
        if(BombOrNot == true)
        {
            Cdetection = true;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        }
    }
}


