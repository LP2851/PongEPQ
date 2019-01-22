using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    private Rigidbody2D rb2d;
	public Vector2 vel;
    public Vector2 finalPos; //Final Position
    public Vector2 initialPos; //Initial Position
    private AudioSource blop;
    private AudioSource pling;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        AudioSource[] sounds = GetComponents<AudioSource>();
        blop = sounds[0];
        pling = sounds[1];
        Invoke("GoBall", 2);
        finalPos = rb2d.transform.position;
        initialPos = rb2d.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        initialPos = finalPos;
        finalPos = rb2d.transform.position;
	}

    void GoBall()
    {
        float rand = Random.Range(0, 2);
        if(rand < 1)
        {
            rb2d.AddForce(new Vector2(20, -15));

        }
        else
        {
            rb2d.AddForce(new Vector2(-20, -15));
        }
        
        
    }
    void ResetBall()
    {
        vel = Vector2.zero;
        rb2d.velocity = vel;
        transform.position = Vector2.zero;

        Vector2 v = rb2d.transform.position;
        Vector2 u = rb2d.transform.position;
        pling.Play();
    }
    void RestartGame()
    {   
        ResetBall();
        Invoke("GoBall", 1);
        blop.volume = 1;
        pling.volume = 1;
    }

    void OnCollisionEnter2D(Collision2D coll) 
    {
        if(coll.collider.CompareTag("Player"))
        {
            vel.x = rb2d.velocity.x;
            vel.y = (rb2d.velocity.y / 2.0f) + (coll.collider.attachedRigidbody.velocity.y / 3.0f);
            rb2d.velocity = vel;
            blop.Play();
        }
        blop.Play();
    }
}
