using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EManagerRandomAngle : MonoBehaviour
{
    public GameObject Enemy;
    public float x1, x2, y1, y2;
    public double TimeToAppear;　// 出る時間
    public int HowManyEnemies;
    public float Interval;
    public float Angle;

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
    }
    
    private IEnumerator Corou()
    {
        Quaternion r = Quaternion.Euler(0, 0, 0);

        for (int i = 1; i <= HowManyEnemies; i++)
        {
            float x = Random.Range(x1, x2);
            float y = Random.Range(y1, y2);
            float z = 0;
            Vector3 position = new Vector3(x, y, z);

            Instantiate(Enemy, position, r);
            yield return new WaitForSeconds(Interval);

            r.z += Angle;
        }
    }
}
