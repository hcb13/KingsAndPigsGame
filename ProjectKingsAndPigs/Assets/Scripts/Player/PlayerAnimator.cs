using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void OnMovement(InputAction.CallbackContext value)
    {
        animator.SetBool("IsRunning", value.ReadValue<Vector2>().x != 0);
    }
}
