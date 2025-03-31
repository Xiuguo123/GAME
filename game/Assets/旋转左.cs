using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 旋转左 : MonoBehaviour
{
    public Transform targetObject;
  
    public float rotationAngle = 15f;


    public void RotateObjectRight()
    {
        if (targetObject != null)
        {

            targetObject.Rotate(Vector3.up * rotationAngle);
        }
    }

    void Start()
    {

    }

    void Update()
    {

    }
}