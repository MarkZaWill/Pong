using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public float speed = 30;
    GameObject ball;
    void Start()
    {
        //this is is initial velocity of the ball
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        ball = GameObject.FindGameObjectWithTag("Ball");
    }
  public float hitFactor(Vector2 ballPosition, Vector2 PaddlePosition, float PaddleHeight)
    {
        return (ballPosition.y - PaddlePosition.y) / PaddleHeight;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "RightWall")
        {
            Destroy(ball, 0.5f);
            
        }
        if (collision.gameObject.name =="LeftRacket")
        {
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
    }
}
