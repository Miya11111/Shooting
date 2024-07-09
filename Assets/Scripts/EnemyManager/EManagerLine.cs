using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EManagerLine : MonoBehaviour
{
    public GameObject Enemy;
    public Vector2 PlaceToAppear; //出る場所
    public float AppearLineGapX;
    public float AppearLineGapY;
    public double TimeToAppear;　// 出る時間
    public int HowManyEnemies;
    public float Interval;
    public float Interval2;
    public float looping;

    private float timer;

    bool CalledOnce = false;


    void Update()
    {
        timer += Time.deltaTime;

        if(timer > TimeToAppear && !CalledOnce)
        {
            CalledOnce = true;
            StartCoroutine("Corou");
            
        }
    }
    
    private IEnumerator Corou()
    {
        for(int j = 1; j <= looping + 1; j++)
        {
            for (int i = 1; i <= HowManyEnemies; i++)
            {
                Instantiate(Enemy, PlaceToAppear, transform.rotation);
                yield return new WaitForSeconds(Interval);
                PlaceToAppear.x += AppearLineGapX;
                PlaceToAppear.y += AppearLineGapY;
            }
            PlaceToAppear.x -= AppearLineGapX * HowManyEnemies;
            PlaceToAppear.y -= AppearLineGapY * HowManyEnemies;

            yield return new WaitForSeconds(Interval2);
        }
    }
}
