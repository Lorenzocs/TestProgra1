using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Button[] buttons;
    public int currentLevel;

    void Start()
    {
        currentLevel = Score.level;
        SetButtons();
    }

    public void SetButtons()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = i <= currentLevel;
        }
    }


}
