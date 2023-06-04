using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Inventory : MonoBehaviour
{
    public int NumberOfDiamonds
    {
        get;
        private set;
    }
    public TextMeshProUGUI highScoreText;
    public UnityEvent<Inventory> Collected;

    public void DiamondCollected()
    {
        NumberOfDiamonds = NumberOfDiamonds+10;
        Collected.Invoke(this);
        CheckHighScore();
        UpdateHighScoreText();
        
    }
    

    void CheckHighScore()
    {
        if(NumberOfDiamonds > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", NumberOfDiamonds);
        }
    }

    void UpdateHighScoreText()
    {
        highScoreText.text = $"HighScore: {PlayerPrefs.GetInt("HighScore", 0)}";
    }
}
