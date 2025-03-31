
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 旋转右 : MonoBehaviour
{
    public Transform targetObject; // 需要旋转的物体
    public float rotationAngle = 15f; // 旋转角度

    // 旋转物体向右（逆时针）
    public void RotateObjectLeft()
    {
        if (targetObject != null)
        {
            targetObject.Rotate(Vector3.up * -rotationAngle); // 逆时针旋转
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}