using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSelector : MonoBehaviour {


    private GameObject vars;
    private GlobalVariables varScript;
    public GameObject LeftPaddleRect;
    public GameObject RightPaddleRect;
    public GameObject LeftPaddleCircle;
    public GameObject RightPaddleCircle;
    public GameObject LeftPaddleHex;
    public GameObject RightPaddleHex;


    // Use this for initialization
    void Start () {
        vars = GameObject.Find("GlobalVariables");
        GlobalVariables varScript = vars.GetComponent<GlobalVariables>();

        if (varScript.paddle == 0)
        {
            Instantiate(LeftPaddleRect);
            Instantiate(RightPaddleRect);
        } else if (varScript.paddle == 1)
        {
            Instantiate(LeftPaddleCircle);
            Instantiate(RightPaddleCircle);
        } else if (varScript.paddle == 2)
        {
            Instantiate(LeftPaddleHex);
            Instantiate(RightPaddleHex);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
