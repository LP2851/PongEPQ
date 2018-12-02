using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour {

    Toggle toggle;
    private string toggleName;
    private bool toggleVal;
    private GameObject vars;
    private GlobalVariables varScript;
	
    // Use this for initialization
	void Start () {
        toggle = GetComponent<Toggle>();
        vars = GameObject.Find("GlobalVariables");

        varScript = vars.GetComponent<GlobalVariables>();
        toggleName = toggle.name;

        


        if (toggleName == "Multiplayer")
        {
            toggle.isOn = varScript.multiplayer;
        } else if(toggleName == "Mayhem")
        {
            toggle.isOn = varScript.mayhem;
        } else if(toggleName == "Timed")
        {
            toggle.isOn = varScript.timed;
        }
        
    }

    // Update is called once per frame
    void Update () {
        if (toggleName == "Multiplayer")
        {
            varScript.multiplayer = toggle.isOn;
        }
        else if (toggleName == "Mayhem")
        {
            varScript.mayhem = toggle.isOn;
        }
        else if (toggleName == "Timed")
        {
            varScript.timed = toggle.isOn;
        }
    }

}
