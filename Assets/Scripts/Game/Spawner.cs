using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject ball;
    //private int x = 0;
    // Use this for initialization
	void Start () {
        InvokeRepeating("SpawnBalls", 1f, 2.5f);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void SpawnBalls()
    {
        Instantiate(ball, transform.position, Quaternion.identity);
    }
}
