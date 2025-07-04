using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public GameObject camera;
    private float startPositionX;
    private float length;
    public float parallaxEffect;
    private float distanceX;
    public float smoothingX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPositionX = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        float distanceX = camera.transform.position.x * parallaxEffect;
        float movement = camera.transform.position.x * (1 - parallaxEffect);

        Vector3 newPositionX = new Vector3(startPositionX + distanceX, transform.position.y, transform.position.z);
        //transform.position = Vector3.Lerp(transform.position, newPositionX, smoothingX * Time.deltaTime);
        transform.position = newPositionX;

        if (movement > startPositionX + length)
        {
            startPositionX += length;
        }
        else if (movement < startPositionX - length)
        {
            startPositionX -= length;
        }
    }


}
