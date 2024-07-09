using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointPower : MonoBehaviour
{
    public int n;
    public Image image;
    public Sprite sprite0;
    public Sprite spriteA;
    public Sprite spriteB;
    public Sprite spriteC;
    public Sprite spriteD;

    // Start is called before the first frame update
    void Start()
    {
        image = this.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PointCounter.point < 25 + n)
        {
            image.sprite = sprite0;
        }

        if (PointCounter.point >= 25 + n)
        {
            image.sprite = spriteA;
        }

        if (PointCounter.point >= 50 + n)
        {
            image.sprite = spriteB;
        }

        if (PointCounter.point >= 75 + n)
        {
            image.sprite = spriteC;
        }

        if (PointCounter.point >= 100 + n)
        {
            image.sprite = spriteD;
        }
    }
}
