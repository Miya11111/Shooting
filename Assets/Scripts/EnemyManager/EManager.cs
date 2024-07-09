using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EManager : MonoBehaviour
{
    public GameObject Enemy;
    public Vector2 PlaceToAppear; //出る場所
    public double TimeToAppear;　// 出る時間
    public int HowManyEnemies;
    public float Interval;
    public float Angle;
    public int LOOPorNOT;
    public int Looptime;

    private float timer;

    bool CalledOnce = false;

    private void Start()
    {
        timer = 0;
    }
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > TimeToAppear && !CalledOnce)
        {
            CalledOnce = true;
            StartCoroutine("Corou");
        }

        if (Looptime < timer && timer < (Looptime + 1) * LOOPorNOT)
        {
            CalledOnce = false;
            timer = 0;
        }
    }
    
    private IEnumerator Corou()
    {
        Quaternion r = Quaternion.Euler(0, 0, Angle);

        for (int i = 1; i <= HowManyEnemies; i++)
        {
            Instantiate(Enemy, PlaceToAppear, r);
            yield return new WaitForSeconds(Interval);
        }
    }
}
