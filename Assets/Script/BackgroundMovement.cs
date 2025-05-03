using UnityEngine;
using UnityEngine.UIElements;

public class BackgroundMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float Velocity = 1.0f;
    public float limit = -14.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * Velocity;
        if(transform.position.x < limit)
        {
            transform.position = new Vector3(24.2f, -0.202f, 0);
        }
    }
}
