using System;
using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    public Rigidbody2D bird;
    public float jump = 10;
    public ScoreIncrement logic;
    private bool Bird_Alive = true;
    public GameObject play;
    public GameObject pause;

    public SpriteRenderer spriteRenderer;  // Assign in Inspector
    public Sprite[] sprites;  // Assign multiple sprites in Inspector
    public float changeInterval = 2f;  // Time between changes
    private int index = 0;
    private float Timer = 0;

    // Start is called once before the first execution of Update after the Mono Behaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<ScoreIncrement>();
        logic.DisplayHighScore();
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0)) && Bird_Alive)
        {
            bird.linearVelocityY = jump;
            bool k = true;
            if (k)
            {
                Time.timeScale = 1f;
                play.SetActive(false);
                pause.SetActive(true);
                k = false;
            }
        }
        if (Timer < changeInterval) Timer += Time.deltaTime;
        else
        {
            index = (index + 1) % sprites.Length;
            spriteRenderer.sprite = sprites[index];
            Timer = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.Game_Over();
        Bird_Alive = false;
    }
}
