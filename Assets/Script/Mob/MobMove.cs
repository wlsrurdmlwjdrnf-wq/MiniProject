using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 0.0f;
    private Vector3 moveDir = Vector3.zero;

    public float MoveSpeed => moveSpeed;

    private void Update()
    {
        transform.position += moveDir * moveSpeed * Time.deltaTime;
    }

    public void MoveMob(Vector3 dir)
    {
        moveDir = dir;
    }
}
