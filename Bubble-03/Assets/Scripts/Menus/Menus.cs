using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menus : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuIU;
    public GameObject DeathMenuIU;
    public GameObject InstructionsMenuIU;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !(PlayerMovement.GameIsEnded)) 
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else 
            {
                Pause();
            }
        }

        if (PlayerMovement.GameIsEnded)
        {
            DeathMenuIU.SetActive(true);
        }
        else 
        {
            DeathMenuIU.SetActive(false);
        }

    }

    public void Resume() 
    {
        PauseMenuIU.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    void Pause()
    {
        PauseMenuIU.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }

    public void LoadMainMenu()
    {
        GameIsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("mainMenu");
    }

    public void QuitGame() 
    {
        Application.Quit();
    }

    public void retry()
    {
        Time.timeScale = 1f;
        DeathMenuIU.SetActive(false);
        SceneManager.LoadScene("GameScene");
    }

    public void instructions() {
        PauseMenuIU.SetActive(false);
        InstructionsMenuIU.SetActive(true);
    }

    public void backPauseMenu() {
        InstructionsMenuIU.SetActive(false);
        PauseMenuIU.SetActive(true);
    }
}
