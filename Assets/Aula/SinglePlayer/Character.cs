using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class Character : MonoBehaviour
{
    protected PlayerActions _actions;

    protected virtual void Awake()
    {
        _actions = new PlayerActions();
        _actions.gameplay.Fire.started += (ctx) => Debug.Log("Fire started");
        _actions.gameplay.Fire.performed += (ctx) => Debug.Log("Fire performed");
        _actions.gameplay.Fire.canceled += (ctx) => Debug.Log("Fire canceled");

    }

    private void OnEnable()
    {
        if (_actions != null)
        {
            _actions.Enable();
        }
    }

    protected virtual void OnDisable()
    {
        if (_actions != null)
        {
            _actions.Disable();
        }
    }
}
