using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Trigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public ScoreIncrement logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<ScoreIncrement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.AddScore(1);
        }
    }
}
