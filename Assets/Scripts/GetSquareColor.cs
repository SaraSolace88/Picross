using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class GetSquareColor : MonoBehaviour
{
    private Controls controls;

    private void OnEnable()
    {
        controls = GetComponent<Controls>();
        controls.Enable();
        controls.Player.TouchInput.performed += ScreenPressed;
    }


    private void OnDisable()
    {
        controls.Disable();
    }

    private void ScreenPressed(InputAction.CallbackContext context)
    {
        throw new NotImplementedException();
    }
}
