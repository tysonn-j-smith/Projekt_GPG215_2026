using UnityEngine;
using UnityEngine.InputSystem;

public class Attack : MonoBehaviour
{
    public void OnAttack(InputAction.CallbackContext ctx)
    {
        if(ctx.started)
        {
            Debug.Log("Attacking!");
        }
    }
}
