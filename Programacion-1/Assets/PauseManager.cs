using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public static bool statePause;
    public UiController uiController;
    

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SetPause();

        }
    }

    public void SetPause()
    {
        statePause = !statePause;
        if (statePause == true)
        {
            uiController.ShowPause();
        }
        else
        {
            uiController.HidePause();
        }
    }
}
