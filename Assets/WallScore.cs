using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScore : MonoBehaviour
{

    //    public int Player1Score = 0;
    //    public int Player2Score = 0;
    //    public Ball ball = new Ball();



    //    void OnTriggerEnter2D(Collider2D collision)
    //    {

    //        if (collision.gameObject.name == "RightWall")
    //        {
    //            string WallName = transform.name;
    //            Score(WallName);
    //            collision.gameObject.SendMessage("RestartGame");
    //        }
    //    }

    //    void Score(string WallName)
    //    {
    //        if (WallName == "RightWall")
    //        {
    //            Player1Score++;
    //            Destroy(ball, 0.5f);
    //        }
    //        else if (WallName == "LeftWall")
    //        {
    //            Player2Score++;
    //            Destroy(ball, 0.5f);
    //        }
    //    }

    //    void OnGUI()
    //    {
    //        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + Player1Score);
    //        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + Player2Score);


    //        if (Player1Score == 10)
    //        {
    //            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER ONE WINS");
    //            gameObject.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
    //        }
    //        else if (Player2Score == 10)
    //        {
    //            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER TWO WINS");
    //            gameObject.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
    //        }
    //    }

}

