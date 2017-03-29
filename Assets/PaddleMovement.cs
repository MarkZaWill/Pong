using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour {
    public static GameObject Player1;
    public static GameObject Player2;
    public GameObject LeftRacket;
    public GameObject RightRacket;
    public float speed = 30;
    public string axis = "Vertical";
    Rigidbody2D rigidball;

    public void Start()
    {
    Transform ball = GameObject.FindGameObjectWithTag("Ball").transform;
    Rigidbody2D rigidball = ball.GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {


            float y = Input.GetAxisRaw(axis);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, y) * speed;


             GameAI();

    }
    public void GameAI()
    {

        if (rigidball.velocity.x < 0)
        {
            if(rigidball.position.y < this.transform.position.y)
            {
                transform.Translate(Vector2.down * speed);
            }
            if(rigidball.position.y > this.transform.position.y)
            {
                transform.Translate(Vector2.up * speed);
            }

        }
    }       
            

        }
