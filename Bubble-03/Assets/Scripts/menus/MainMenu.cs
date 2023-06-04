using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start() 
    {
        Resolution[] resolutions = Screen.resolutions;
        Resolution targetResolution = resolutions[resolutions.Length - 1]; // Choose the last resolution in the list (usually the highest)

        // Set the resolution
        Screen.SetResolution(targetResolution.width, targetResolution.height, true);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
