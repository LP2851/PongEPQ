using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleAI : MonoBehaviour {

    public GameObject ball;
    public float speed = 10.0f;
    public float boundX = 10.0f;
    private Rigidbody2D rb2d;
    

    // Use this for initialization
	void Start () {
        ball = GameObject.Find("Ball");
        rb2d = GetComponent<Rigidbody2D>();
        
	}
	
	

    // Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;

        // move sprite towards the target location
        Vector2 ballPosTest = ball.transform.position;

        //Vector2 ballPosTest = AnticipateBallPos();


        ballPosTest.x += ball.GetComponent<CircleCollider2D>().radius; //0.5f;
        if (transform.position.x >= ballPosTest.x) //ball.transform.position.x)
        {
            transform.position = Vector2.MoveTowards(transform.position, ballPosTest, step);//ball.transform.position, step);
        }
        else if(transform.position.y < ball.transform.position.y)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(100, -10), step);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(100, 10), step);
        }
        var pos = transform.position;
        if (pos.x > boundX)
        {

            pos.x = boundX;
            transform.position = pos;
        } else if (pos.x < -boundX)
        {
            pos.x = -boundX;
            transform.position = pos;
        }
        

        
    }

    Vector2 AnticipateBallPos()
    {
        Vector2 antipos;

        float ballx = ball.transform.position.x;
        float bally = ball.transform.position.y;

        Vector2 bvel = ball.GetComponent<BallControl>().vel;

        antipos = new Vector2(ballx + bvel.x, bally + bvel.y);

        return antipos;
    }

    Vector2 Anticipate()
    {
        Vector2 aim = ball.transform.position;
        aim.x += ball.GetComponent<CircleCollider2D>().radius;
        Vector2 paddlePos = rb2d.transform.position;
        BallControl ballScript = ball.GetComponent<BallControl>();
        float ballx2 = ballScript.finalPos.x;
        float bally2 = ballScript.finalPos.y;
        float ballx1 = ballScript.initialPos.x;
        float bally1 = ballScript.initialPos.y;

        float distance = Mathf.Sqrt(Mathf.Pow(ballx2-ballx1, 2) + Mathf.Pow(bally2-bally1, 2));

        float vel = distance/Time.deltaTime;

        float distanceFromBall = Mathf.Sqrt(Mathf.Pow(ballx2 - transform.position.x, 2) + Mathf.Pow(bally2 - transform.position.y, 2));

        while(false)
        {
            break;
        }

        return aim;
    }


    ///<summary>
    ///
    /// ballPos = (6, 5)
    /// 
    /// Radius of Ball: 0.08756419 get as constant
    /// Anticipate closest point on ball to home side pos when reached => BallVector.x + Radius
    /// See if the ball is boucing up or down, or grad = 0
    /// Calc pos based on vel (u and v), acc, time with ball pos as point 2
    /// 
    /// 
    /// </summary>
}
