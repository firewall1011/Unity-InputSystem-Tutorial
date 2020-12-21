using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Acoes : MonoBehaviour
{
    public Vector2 MoveDir = Vector2.zero;
    public float RotateDir = 0f;
    public float MoveSpeed = 10f;
    public float RotateSpeed = 100f;

    public void OnDance()
    {
        Debug.Log("E hee!");
    }

    public void OnSuperDance()
    {
        Debug.Log("Ow!");
    }

    public void OnMove(InputValue input)
    {
        MoveDir = input.Get<Vector2>();
    }

    private void Update()
    {
        transform.Translate(MoveDir * MoveSpeed * Time.deltaTime);
    }
}
