using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour {

    public static int Player1Score = 0;
    public static int Player2Score = 0;

    public BoxCollider2D TopWall;
    public BoxCollider2D BottomWall;
    public BoxCollider2D LeftWall;
    public BoxCollider2D RightWall;

    public GUISkin layout;

    Transform BallTransform;
    private void Start()
    {
        BallTransform = GameObject.FindGameObjectWithTag("Ball").transform;
    }

    public static void Score (string Wall)
    {
        Console.WriteLine(Wall);
        if (Wall == "RightWall")
        {
            Player1Score++;
        }
        else if (Wall == "LeftWall")
        {
            Player2Score++;
        }
    }

   void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + Player1Score);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + Player2Score);

        if (Player1Score == 10)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER ONE WINS");
            BallTransform.gameObject.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
        else if (Player2Score == 10)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER TWO WINS");
            BallTransform.gameObject.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
    }
}

