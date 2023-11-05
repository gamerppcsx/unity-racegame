using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour{

    public static bool GameIsPaused = false;


    public GameObject pauseMenuUI;
    public GameObject pauseMenu2UI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }else
            {
                Pause();
            }
        }

    }

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        pauseMenu2UI.SetActive(false);
    }

    public void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        pauseMenu2UI.SetActive(false);
    }
    public void quit()
    {
        SceneManager.LoadScene("menuXD");
    }
    public void tijden ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = false;
        pauseMenu2UI.SetActive(true);
    }
}
