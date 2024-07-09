using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour
{
    //移動可能な範囲
    public static Vector2 m_moveLimit = new Vector2(-5.7f, -4.8f);
    public static Vector2 n_moveLimit = new Vector2(1.8f, 4.8f);
    //指定された位置を移動可能な範囲に収めた値を返す
    public static Vector3 ClampPosition( Vector3 position)
    {
        return new Vector3
            (
               Mathf.Clamp( position.x, m_moveLimit.x,n_moveLimit.x),
               Mathf.Clamp(position.y, m_moveLimit.y, n_moveLimit.y),0
            );
    }
}
