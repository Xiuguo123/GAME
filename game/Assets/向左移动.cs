
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 向左移动 : MonoBehaviour
{
    public Transform targetObject; // 需要移动的物体
    public float moveDistance = 1f; // 每次移动的距离

    // 让物体向左移动
    public void MoveObjectLeft()
    {
        if (targetObject != null)
        {
            targetObject.position += Vector3.left * moveDistance; // 向左移动
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}