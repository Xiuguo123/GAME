
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 重置 : MonoBehaviour
{
    public Transform targetObject; // 需要重置的物体
    private Vector3 originalPosition; // 物体的原始位置
    private Quaternion originalRotation; // 物体的原始旋转
    private Vector3 originalScale; // 物体的原始大小

    void Start()
    {
        // 保存物体的初始位置、旋转和大小
        if (targetObject != null)
        {
            originalPosition = targetObject.position;
            originalRotation = targetObject.rotation;
            originalScale = targetObject.localScale;
        }
    }

    // 重置物体的状态（位置、旋转、缩放）
    public void ResetObjectTransform()
    {
        if (targetObject != null)
        {
            targetObject.position = originalPosition; // 恢复到原始位置
            targetObject.rotation = originalRotation; // 恢复到原始旋转
            targetObject.localScale = originalScale; // 恢复到原始大小
        }
    }

    // 让物体向左移动
    public void MoveObjectLeft(float moveDistance)
    {
        if (targetObject != null)
        {
            targetObject.position += Vector3.left * moveDistance; // 向左移动
        }
    }

    // 让物体向右移动
    public void MoveObjectRight(float moveDistance)
    {
        if (targetObject != null)
        {
            targetObject.position += Vector3.right * moveDistance; // 向右移动
        }
    }

    // 让物体变大
    public void ScaleObjectUp(float scaleFactor)
    {
        if (targetObject != null)
        {
            targetObject.localScale *= scaleFactor; // 按比例变大
        }
    }

    // 让物体变小
    public void ScaleObjectDown(float scaleFactor)
    {
        if (targetObject != null)
        {
            targetObject.localScale *= scaleFactor; // 按比例变小
        }
    }

    // 旋转物体向右
    public void RotateObjectRight(float rotationAngle)
    {
        if (targetObject != null)
        {
            targetObject.Rotate(Vector3.up * rotationAngle); // 右旋
        }
    }

    // 旋转物体向左
    public void RotateObjectLeft(float rotationAngle)
    {
        if (targetObject != null)
        {
            targetObject.Rotate(Vector3.up * -rotationAngle); // 左旋
        }
    }

    void Update()
    {
        // 可以在这里处理一些持续性逻辑，比如按键触发重置
    }
}