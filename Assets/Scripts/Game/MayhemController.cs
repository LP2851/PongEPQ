using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayhemController : MonoBehaviour {

    public GameObject ball;
    private GameObject vars;
    private GlobalVariables varScript;
    public GameObject manager;


	// Use this for initialization
	void Start () {
        vars = GameObject.Find("GlobalVariables");
        manager = GameObject.Find("HUD");
        GlobalVariables varScript = vars.GetComponent<GlobalVariables>();
        if(varScript.mayhem)
        {
            varScript.maxScore = 100;
            manager.GetComponent<GameManager>().winVal = varScript.maxScore;
            
            InvokeRepeating("SpawnBalls", 1f, 2.5f);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void SpawnBalls()

    {
        Instantiate(ball, transform.position, Quaternion.identity);
    }
}
