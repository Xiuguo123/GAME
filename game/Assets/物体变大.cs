using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 物体变大 : MonoBehaviour
{
    public Transform targetObject; // 需要变大的物体
    public float scaleFactor = 1.2f; // 每次变大的比例

    // 让物体变大
    public void ScaleObjectUp()
    {
        if (targetObject != null)
        {
            targetObject.localScale *= scaleFactor; // 按照比例变大
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}