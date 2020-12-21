using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerPause : MonoBehaviour
{
    public GameObject PauseScreen = null;
    [SerializeField] private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _playerInput.actions["Pause"].performed += PlayerPause_performed;
    }

    private void PlayerPause_canceled(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    public void PlayerPause_performed(InputAction.CallbackContext ctx)
    {
        if(PauseScreen != null)
        {
            if (!PauseScreen.activeInHierarchy)
            {
                PauseScreen.SetActive(true);
                _playerInput.DeactivateInput();
            }

        }
    }

    public void UnPause()
    {
        PauseScreen.SetActive(false);
        _playerInput.ActivateInput();
    }
}
