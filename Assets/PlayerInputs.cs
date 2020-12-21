using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
    public float RotateSpeed = 200f;
    public float MoveSpeed = 0f;

    private float rotateValue = 0f;
    private Vector2 MoveDir = Vector2.zero;



    private void Start()
    {
        PlayerInput playerInput = GetComponent<PlayerInput>();
        InputActionAsset actions = playerInput.actions;
        actions["Atirar"].started += SuperAtirarStarted;
        actions["Atirar"].canceled += (ctx) => Debug.Log("Sem piu");
    }

    private void SuperAtirarStarted(InputAction.CallbackContext obj)
    {
        Debug.Log("Piuzao");
    }

    public void OnAtirar()
    {
        Debug.Log("Piu!");
    }

    public void OnRotacionar(InputValue input)
    {
        rotateValue = input.Get<float>();
    }

    public void OnMover(InputValue input)
    {
        MoveDir = input.Get<Vector2>();
    }

    public void OnSuperAtirar()
    {
        Debug.Log("PPPPPPPPPPPPPIIIIIIIIIIIIIIUUUUUUUUUU");
    }

    private void Update()
    {
        //transform.Rotate(rotateValue * RotateSpeed * Time.deltaTime);
        transform.Translate(MoveDir * MoveSpeed * Time.deltaTime, Space.World);
        transform.Rotate(new Vector3(0f, 0f, -rotateValue * RotateSpeed * Time.deltaTime));
    }
}
