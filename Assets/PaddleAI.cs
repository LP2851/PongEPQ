﻿using System.Collections;
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
        if(transform.position.x > ball.transform.position.x)
        {
            transform.position = Vector2.MoveTowards(transform.position, ball.transform.position, step);
        }
        else if(transform.position.y < ball.transform.position.y)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(100, -10), step);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(100, 10), step);
        }
        
    }

}
