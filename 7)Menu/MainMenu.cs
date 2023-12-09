using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void StartButton()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void SelectLevelButton()
    { 
        SceneManager.LoadScene("Select Levels");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
