//using UnityEditor.Animations;
//using UnityEngine;

//public class PlayerMovement : MonoBehaviour
//{

//    public Rigidbody2D rigidbody;
//    public float walkSpeed = 5f;


//    public GameObject playerVisualObj;
//    private Animator animatorParams;


//    public float turnAroundSpeed;
//    private float rotationAngle;

//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    void Start()
//    {
//        animatorParams = playerVisualObj.GetComponent<Animator>();
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        turnAround(rotationAngle);
//        animatorParams.SetBool("Running", false);
//        // Barebones movement, will delete/change later


//        if (Input.GetKey(KeyCode.A))
//        {
//            rotationAngle = 180;
//            transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
//            animatorParams.SetBool("Running", true);
//        }
//        if (Input.GetKey(KeyCode.D))
//        {
//            rotationAngle = 0;
//            transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);
//            animatorParams.SetBool("Running", true);
//        }


//    }

//    private void turnAround(float angle)
//    {
//        Vector3 targetAngle = new Vector3(0, angle, 0);
//        if (playerVisualObj.transform.eulerAngles != targetAngle) {
//            playerVisualObj.transform.eulerAngles = Vector3.Lerp(playerVisualObj.transform.eulerAngles, targetAngle, turnAroundSpeed * Time.deltaTime);
//        }
//    }

 

//}
