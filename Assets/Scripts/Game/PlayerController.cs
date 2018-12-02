using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public KeyCode moveLeft = KeyCode.LeftArrow;
    public KeyCode moveRight = KeyCode.RightArrow;
    public KeyCode moveUp = KeyCode.UpArrow;
    public KeyCode moveDown = KeyCode.DownArrow;
    public float speed = 10.0f;
    public float boundX = 6.0f;
    private Rigidbody2D rb2d;



	// Use this for initialization
	void Start () {
        rb2d = GetComponent < Rigidbody2D >();

	}
	
	// Update is called once per frame
	void Update () {
        var vel = rb2d.velocity;
        if(Input.GetKey(moveLeft))
        {
            vel.x = -speed;
        }
        else if(Input.GetKey(moveRight))
        {
            vel.x = speed;
        }
        else if(Input.GetKey(moveUp))
        {
            vel.y = speed;
        }
        else if(Input.GetKey(moveDown))
        {
            vel.y = -speed;
        }
        else if(!Input.anyKey)
        {
            vel.x = 0;
            vel.y = 0;
        }
        rb2d.velocity = vel;
        var pos = transform.position;
        if (pos.x > boundX)
        {
            pos.x = boundX;

        }
        else if (pos.x < -boundX)
        {
            pos.x = -boundX;
        }
        transform.position = pos;
	}
}
