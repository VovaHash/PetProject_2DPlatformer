using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Barebones movement, will delete/change later


        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);
        }

        
    }
}
