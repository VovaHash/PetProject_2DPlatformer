using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class PlayerAnimationsController : MonoBehaviour
{

    [SerializeField] PlayerControllerScript playerController;
    public Animator animator;

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

        if (playerController.isWalking && playerController.horizontal != 0)
        {
            animator.SetBool("Running", true);
        }
        else
        {
            animator.SetBool("Running", false);
        }

    }



}
