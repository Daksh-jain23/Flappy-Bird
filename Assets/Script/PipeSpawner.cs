using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float rate = 1.7f;
    private float timer = 0;
    public float maxrangepipe = 6;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawner();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < rate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Spawner();
            timer = 0;
        }
    }
    void Spawner()
    {
        float lowest = transform.position.y - maxrangepipe ;
        float highest = transform.position.y + maxrangepipe ;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowest,highest), 0) , transform.rotation);
    }
}
