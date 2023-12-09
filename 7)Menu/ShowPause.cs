using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowPause : MonoBehaviour
{

    public GameObject PauseMenu;

    private void Start()
    {
        PlayerPrefs.SetInt("Count", 0);
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
    }

    public void ShowPauseMenu()
    {
        PauseMenu.SetActive(true);

        Time.timeScale = 0;
    }
    public void HidePauseMenu()
    {
        PauseMenu.SetActive(false);

        Time.timeScale = 1;
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Pause");

        Time.timeScale = 1;
    }
}
