using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public float speed = 30;
    private Rigidbody2D Rigid;
    public Vector2 right = new Vector2(20.0f, -15.0f);
    public Vector2 left = new Vector2(-20.0f, -15.0f);
    public Vector2 v2;
//    void BallMove() { 
//        float random = Random.Range(0.0f, 2.0f);
//            if(random< 1.0f)
//            {
//                Rigid.AddForce(right);
//            }
//            else
//            {
//                Rigid.AddForce(left);
//            }
//}
    void Start()
    {
        //this is is initial velocity of the ball
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
       Transform ball = GameObject.FindGameObjectWithTag("Ball").transform;
    }
  public float hitFactor(Vector2 ballPosition, Vector2 PaddlePosition, float PaddleHeight)
    {
        return (ballPosition.y - PaddlePosition.y) / PaddleHeight;
    }

    public void ResetBall()
    {
        v2.y = 0;
        v2.x = 0;
        

    }
   void RestartGame()
    {
        ResetBall();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name =="LeftRacket")
        {
            Console.WriteLine(collision.gameObject.name);
            float y = hitFactor(transform.position,
                                collision.transform.position,
                                collision.collider.bounds.size.y);
            Vector2 direction = new Vector2(1, y).normalized;

            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
       
        if( collision.gameObject.name == "RightRacket")
        {

            float y = hitFactor(transform.position,
                                collision.transform.position,
                                collision.collider.bounds.size.y);

            Vector2 direction = new Vector2(-1, y).normalized;

            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }

        if( collision.gameObject.name == "RightWall")
        {
            
            GameBoard.Score(collision.gameObject.name);
            RestartGame();
        }

        if( collision.gameObject.name == "LeftWall")
        {
           
            GameBoard.Score(collision.gameObject.name);
            RestartGame();
        }
    }
}
