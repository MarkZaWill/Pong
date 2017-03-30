using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour {

    public float speed = 30;
    public string axis = "Vertical";
    

    public void Start()
    {
    Transform ball = GameObject.FindGameObjectWithTag("Ball").transform;
    }

    //fixed update sets a fixed time that the game updates the information received, so it will get the input from the players
    //consistently and at the same time
    void FixedUpdate()
    {
            float y = Input.GetAxisRaw(axis);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, y) * speed;      

    }
 }
