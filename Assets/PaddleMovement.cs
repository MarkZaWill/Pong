using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour {

    public float speed = 30;
    public string axis = "Vertical";
    private void FixedUpdate()
    {
        float y = Input.GetAxisRaw(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, y) * speed; 
    }

}
