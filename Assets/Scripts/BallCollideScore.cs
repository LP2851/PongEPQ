using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollideScore : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.CompareTag("Points"))
        {
            string pointName = transform.name;
            GameManager.Score(pointName);
            hitInfo.gameObject.SendMessage("GoBall", 1.0f, SendMessageOptions.RequireReceiver);

        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
