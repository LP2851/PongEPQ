using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalVariables : MonoBehaviour {

    // <summary>Static reference to the instance of our DataManager</summary>
    public static GlobalVariables instance;

    public int paddle; // 0 normal, 1 circle, 2 hex
    public int maxScore;

    public bool timed = true;
    public bool multiplayer = false;
    public bool mayhem = false;

    /// <summary>Awake is called when the script instance is being loaded.</summary>
    void Awake()
    {
        // If the instance reference has not been set, yet, 
        if (instance == null)
        {
            // Set this instance as the instance reference.
            instance = this;
        }
        else if (instance != this)
        {
            // If the instance reference has already been set, and this is not the
            // the instance reference, destroy this game object.
            Destroy(gameObject);
        }

        // Do not destroy this object, when we load a new scene.
        DontDestroyOnLoad(gameObject);
    }

    public void SetPaddle(string x)
    {
        if(x == "Rectangle")
        {
            paddle = 0;
        } else if(x == "Circle")
        {
            paddle = 1;
        } else if(x == "Hexagon")
        {
            paddle = 2;
        }

    }
    public void SetMaxScore(int x)
    {
        maxScore = x;
    }
    public void ToggleTimed()
    {
        timed = !timed;
    }
    public void ToggleMutliplayer()
    {
        multiplayer = !multiplayer;
    }
    public void ToggleMayhem()
    {
        mayhem = !mayhem;
    }
}
