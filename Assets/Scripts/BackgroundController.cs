using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public GameObject camera;
    private float startPositionX;
    public float parallaxEffect;
    private float distanceX;
    public float smoothingX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPositionX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {   
        float distanceX = camera.transform.position.x * parallaxEffect;
        Vector3 newPositionX = new Vector3(startPositionX + distanceX, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newPositionX, smoothingX * Time.deltaTime);
    }


}
