using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void goMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void resume()
    {
        SceneManager.LoadScene("GameScene");
    }
}