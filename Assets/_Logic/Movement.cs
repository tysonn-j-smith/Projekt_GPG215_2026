using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Vector3 rawInputMovement;

    public void OnMovement(InputAction.CallbackContext ctx)
    {
        Vector2 inputMovement = ctx.ReadValue<Vector2>();
        rawInputMovement = new Vector3(inputMovement.x, 0f, inputMovement.y);
        rawInputMovement.Normalize();

        Debug.Log("X: " + inputMovement.x.ToString() + " Y: " + inputMovement.y.ToString());
    }
}
