using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class ButtonDoorTwo : MonoBehaviour
{
    public bool active;
    public Door myDoor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerTest player = collision.GetComponent<PlayerTest>();

        if (player != null)// el objeto es el jugador? 
        {
            print("Boton presionado:" + gameObject.name);
            active = true;
            myDoor.CheckButtons();
        }
    }
}
