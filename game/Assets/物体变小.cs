using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 物体变小 : MonoBehaviour
{
    public Transform targetObject; // 需要变小的物体
    public float scaleFactor = 0.8f; // 每次变小的比例

    // 让物体变小
    public void ScaleObjectDown()
    {
        if (targetObject != null)
        {
            targetObject.localScale *= scaleFactor; // 按照比例变小
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}