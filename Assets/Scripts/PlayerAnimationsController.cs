using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class PlayerAnimationsController : MonoBehaviour
{

    [SerializeField] PlayerControllerScript player;
    private Animator animator;

    [Header("Run animation")]
    [SerializeField] string walkParamName;
    [SerializeField] bool walkParamValue;
    
    [Header("Jump animation")]
    [SerializeField] string jumpParamName;
    [SerializeField] bool jumpParamValue;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isJumping == false)
        {
            animator.SetBool("Jump", false);
        }
        //if (player.isGrounded() && !player.isJumping)
        //{
        //    animator.SetBool("Jump", false);
        //}

        if (player.isWalking && player.horizontal != 0 )
        {
            animator.SetBool("Running", true);
        }
        else
        {
            animator.SetBool("Running", false);
        }


        if (player.isGrounded() && player.isJumping)
        {
            animator.SetBool("Jump", true);
        }
    }



}
