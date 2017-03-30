using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour {

    public static int Player1Score = 0;
    public static int Player2Score = 0;
    
    //establish that this element (position, location of the ball) exists
    Transform BallTransform;
    private void Start()
    {
        //establishes that that BallTransform is the information being received from the ball
        BallTransform = GameObject.FindGameObjectWithTag("Ball").transform;
    }

    //logic for incrementing the score
    public static void Score (string Wall)
    {
        
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
        //labels the game board with the scores
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + Player1Score);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + Player2Score);

        //sets win logic
        if (Player1Score == 10)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER ONE WINS");
            BallTransform.gameObject.SendMessage("ResetBall");
        }
        else if (Player2Score == 10)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER TWO WINS");
            BallTransform.gameObject.SendMessage("ResetBall");
        }
    }
}

