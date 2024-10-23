using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    public GameObject block;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerTest player = collision.GetComponent<PlayerTest>();
        if (player != null)// el objeto es el jugador? 
        {
            block.SetActive(true);
            Destroy(gameObject);
        }

    }
}
