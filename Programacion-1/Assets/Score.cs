using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{


    public int highScore;
    public int currentScore;

    public static int level;
    
  
    void Awake()
    {
       //ResetKeys();
        //  AddScore(5);
        UpdateLevel(0);
    }


    public void UpdateLevel(int newLevel)
    {
        if (PlayerPrefs.HasKey("Level"))
        {
            level = PlayerPrefs.GetInt("Level");
        }
        else
        {
            Debug.Log("No existia la key de nivel");
            level = 0;

            PlayerPrefs.SetInt("Level", level);
            PlayerPrefs.Save();
        }

        if (newLevel > level)
        {
            level = newLevel;
            PlayerPrefs.SetInt("Level", level);
            PlayerPrefs.Save();
            Debug.Log("Se guardo nuevo Nivel");
        }
    }

    public void AddScore(int score)
    {
        currentScore = score;
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            Debug.Log("No existia la key");
            highScore = 0;

            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }

        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
            Debug.Log("Se guardo nuevo score");
        }
    }

    public void ResetKeys()
    {
        //PlayerPrefs.SetInt("HighScore", 0);
        PlayerPrefs.DeleteKey("Level");
        PlayerPrefs.Save();
    }
}
