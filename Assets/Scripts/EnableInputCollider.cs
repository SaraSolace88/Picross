using UnityEngine;
using UnityEngine.InputSystem;

public class EnableInputCollider : MonoBehaviour
{
    private Controls controls;
    private bool interacting;

    private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        controls.Player.Interact.performed += Initial;
        controls.Player.Interact.canceled += End;

    }

    private void OnDisable()
    {
        controls.Player.Interact.performed -= Initial;
        controls.Player.Interact.canceled -= End;
        controls.Disable();
    }

    private void Update()
    {
        if(interacting)
        {
            Touch();
        }
    }

    private void Initial(InputAction.CallbackContext c)
    {
        interacting = true;
        gameObject.GetComponent<CircleCollider2D>().enabled = true;
    }

    private void End(InputAction.CallbackContext c)
    {
        interacting = false;
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
    }

    private void Touch()
    {
        Vector2 position = Camera.main.ScreenToWorldPoint(controls.Player.Position.ReadValue<Vector2>());
        transform.position = position;
    }
}