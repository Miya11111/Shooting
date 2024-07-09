using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPControl_Manager : MonoBehaviour
{

    private int hp = 1;
    private Slider _slider;
    public GameObject slider;

    public GameObject BossMM;
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject gameclear;

    private float timer;
    public int HP
    {
        get { return this.hp; }
        set { this.hp = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        _slider = slider.GetComponent<Slider>();
        StartCoroutine("HPstart");
    }



    // Update is called once per frame
    void Update()
    {
        _slider.value = hp;

        if(HP <= 0)
        {
            PlayerControl.Cdetection = false;

            A.gameObject.SetActive(false);
            B.gameObject.SetActive(false);
            C.gameObject.SetActive(false);
            D.gameObject.SetActive(false);
            BossMM.gameObject.SetActive(false);
            slider.gameObject.SetActive(false);
            StartCoroutine("CLEAR");
        }
    }

    IEnumerator HPstart()
    {
        while (true)
        {
            hp += 8;
            yield return new WaitForSeconds(0.02f);
            if (hp > _slider.maxValue)
            {
                yield break;
            }
        }
    }

    IEnumerator CLEAR()
    {
        yield return new WaitForSeconds(7f);
        gameclear.gameObject.SetActive(true);
    }
}
