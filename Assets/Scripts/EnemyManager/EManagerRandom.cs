using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EManagerRandom : MonoBehaviour
{
    public GameObject Enemy;
    public float x1, x2, y1, y2;
    public double TimeToAppear;　// 出る時間
    public int HowManyEnemies;
    public float Interval;
    public int LOOPorNOT;
    public int Looptime;

    private float timer;

    bool CalledOnce = false;

    void Start()
    {

    }
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > TimeToAppear && !CalledOnce)
        {
            CalledOnce = true;
            StartCoroutine("Corou");
            
        }

        if (timer > Looptime)
        {
            CalledOnce = false;
            timer = 0;
        }
    }
    
    private IEnumerator Corou()
    {
        for (int i = 1; i <= HowManyEnemies; i++)
        {
            float x = Random.Range(x1, x2);
            float y = Random.Range(y1, y2);
            float z = 0;
            Vector3 position = new Vector3(x, y, z);

            Instantiate(Enemy, position, transform.rotation);
            yield return new WaitForSeconds(Interval);
        }
    }
}
