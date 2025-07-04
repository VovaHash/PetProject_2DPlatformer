using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerScript : MonoBehaviour
{
    [Header("Player Component References")]
    [SerializeField] Rigidbody2D playerRigidBody;
    [SerializeField] GameObject playerVisual;
    private PlayerAnimationsController animationControls;


    [Header("Player Settings")]
    [SerializeField] float speed;
    [SerializeField] float jumpingPower;

    [Header("Grounding")]
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Transform groundCheck;

    public bool isWalking;
    public bool isJumping;
    private bool isFacingRight = true;

    public float horizontal;

    private void Start()
    {

        animationControls = playerVisual.GetComponent<PlayerAnimationsController>();
    }
    private void FixedUpdate()
    {
        playerRigidBody.linearVelocityX = horizontal * speed;
        Turn();
        Debug.Log(isFacingRight);
    }


    #region PLAYER_CONTROLS
    public void Move(InputAction.CallbackContext context)
    {

        horizontal = context.ReadValue<Vector2>().x;
        isWalking = true;
   
    }

    public void Turn()
    {
        if (isFacingRight && horizontal < 0 || !isFacingRight && horizontal > 0)
        {
            isFacingRight = !isFacingRight;
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && isGrounded())
        {
            animationControls.animator.SetTrigger("JumpTrigger");
            playerRigidBody.linearVelocityY = jumpingPower;
        }
    }



    public bool isGrounded()
    {
        return Physics2D.OverlapCapsule(groundCheck.position, new Vector2(5.7f,1.1f), CapsuleDirection2D.Horizontal, 0, groundLayer);
    }


    public void Aiming(InputAction.CallbackContext context)
    {
  
    }

    private void JumpCancel() { isJumping = false; }

        #endregion

    }
