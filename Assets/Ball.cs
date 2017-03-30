using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    //set initial speed
    public float speed = 30;
    // set direction game start
    public Vector2 right = new Vector2(20.0f, -15.0f);
    public Vector2 left = new Vector2(-20.0f, -15.0f);
    public Vector2 end = new Vector2(0f, 0f);
    public Vector2 v2;

    void Start()
    {
        //this is is initial velocity of the ball
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
       Transform ball = GameObject.FindGameObjectWithTag("Ball").transform;
    }
  public float hitFactor(Vector2 ballPosition, Vector2 PaddlePosition, float PaddleHeight)
    {
        //changes the trajectory of the ball depending on where it hits the paddle
        return (ballPosition.y - PaddlePosition.y) / PaddleHeight;
    }

    public void ResetBall()
    {
        //move the ball to the center of the game board after a score
        transform.position = new Vector2(0, 0);
    }
   void RestartGame()
    {

        //originally had logic for resetting game board.  Will update with this logic in next update
        ResetBall();
        GetComponent<Rigidbody2D>().velocity = end;
    }

    //sets game logic for what happens when a collision happens with a game object during play
    void OnCollisionEnter2D(Collision2D collision)
    {
        //logic for left paddle
        
        if (collision.gameObject.name =="LeftRacket")
        {
            Console.WriteLine(collision.gameObject.name);
            float y = hitFactor(transform.position,
                                collision.transform.position,
                                collision.collider.bounds.size.y);
            Vector2 direction = new Vector2(1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
       
        //logic for right paddle

        if( collision.gameObject.name == "RightRacket")
        {
            float y = hitFactor(transform.position,
                                collision.transform.position,
                                collision.collider.bounds.size.y);
            Vector2 direction = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }

        //logic for initiating player one scoring by hitting the right wall
        if( collision.gameObject.name == "RightWall")
        {
           GameBoard.Score(collision.gameObject.name);
           ResetBall();
        }

        //logic for initiating player two scoring by hitting left wall
        if( collision.gameObject.name == "LeftWall")
        {
            GameBoard.Score(collision.gameObject.name);
            ResetBall();
        }
    }
}
