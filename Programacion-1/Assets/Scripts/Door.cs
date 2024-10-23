using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public ButtonDoorTwo[] buttons;

    public void CheckButtons()
    {
        foreach (ButtonDoorTwo button in buttons)
        {
            if (button.active == false)
            {
                print("No estoy listo");
                return;
            }
        }
        gameObject.SetActive(false);
    }
}
