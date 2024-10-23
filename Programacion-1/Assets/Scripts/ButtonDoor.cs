using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoor : MonoBehaviour
{
    public GameObject door;
    public bool isOpen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerTest player = collision.GetComponent<PlayerTest>();
        if (player != null)// el objeto es el jugador? 
        {
            isOpen = !isOpen;
            if (door != null)
            {
                door.SetActive(isOpen);
                // Destroy(door);
            }
        }
    }
}
