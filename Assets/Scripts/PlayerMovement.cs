using UnityEditor.Animations;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed;
    public GameObject playerVisual;
    private Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = playerVisual.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        // Barebones movement, will delete/change later

        anim.SetBool("Running", false);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
            anim.SetBool("Running", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);
            anim.SetBool("Running", true);
        }


    }
}
