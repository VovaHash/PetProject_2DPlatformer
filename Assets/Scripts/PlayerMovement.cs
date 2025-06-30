using UnityEditor.Animations;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed;
    public GameObject playerVisualObj;
    private Animator animatorParams;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animatorParams = playerVisualObj.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        animatorParams.SetBool("Running", false);
        // Barebones movement, will delete/change later


        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
            animatorParams.SetBool("Running", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);
            animatorParams.SetBool("Running", true);
        }


    }
}
