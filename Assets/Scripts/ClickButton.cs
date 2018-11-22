using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickButton : MonoBehaviour {

    public void GotoScene1()
    {
        SceneManager.LoadScene("Scene 1");
    }

    public void GotoScene2()
    {
        SceneManager.LoadScene("Scene 2");
    }

    public void GoToScene3()
    {
        SceneManager.LoadScene("Scene 3");
    }

    public void GotoScene4()
    {
        SceneManager.LoadScene("Scene 4");
    }

    public void GoToScene5()
    {
        SceneManager.LoadScene("Scene 5");
    }

    public void GoToScene6()
    {
        SceneManager.LoadScene("Scene 6");
    }

    public void GotoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }

    public void GotoVersions()
    {
        SceneManager.LoadScene("Versions");
    }

}
   
