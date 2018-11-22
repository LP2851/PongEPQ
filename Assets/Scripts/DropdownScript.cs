using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownScript : MonoBehaviour {

	Dropdown dropdown;
    string dropdownVal;
    GameObject vars;

    // Use this for initialization
    void Start () {
        dropdown = GetComponent<Dropdown>();
        vars = GameObject.Find("GlobalVariables");
    }
	
	// Update is called once per frame
	void Update () {

        dropdownVal = dropdown.captionText.text;

        //Debug.Log(dropdownVal);
        Paddle();
    }
    public void Paddle()
    {
        vars.gameObject.SendMessage("SetPaddle", dropdownVal, SendMessageOptions.RequireReceiver);
    }


}
