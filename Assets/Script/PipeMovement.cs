using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float velocity = 5;
    public float Deadzone = -12;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += ( Vector3.left *  velocity ) * Time.deltaTime;
        if(transform.position.x < Deadzone) { 
            Destroy(gameObject);
        }
    }
}
