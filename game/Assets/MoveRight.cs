
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public Transform targetObject; // 需要移动的物体
    public float moveDistance = 1f; // 每次移动的距离

    // 让物体向右移动
    public void MoveObjectRight()
    {
        if (targetObject != null)
        {
            targetObject.position += Vector3.right * moveDistance; // 向右移动
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}