using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 MoveDir = Vector2.zero;
    public float RotateDir = 0f;
    public float MoveSpeed = 10f;
    public float RotateSpeed = 100f;


    public void OnMove(InputValue movementInput)
    {
        Debug.Log("I'm Moving baby!");
        MoveDir = movementInput.Get<Vector2>();
    }

    public void OnRotate(InputValue rotateInput)
    {
        Debug.Log("Rotating at you!");
        RotateDir = rotateInput.Get<float>();
    }

    private void FixedUpdate()
    {
        transform.Translate(MoveDir * MoveSpeed * Time.deltaTime, Space.World);
        transform.Rotate(new Vector3(0f, 0f, -RotateDir * RotateSpeed * Time.deltaTime));
    }
}
