using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactive : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScriptAnimation player=collision.GetComponent<ScriptAnimation>();
        if(player != null)
        {
            player.texto.gameObject.SetActive(true);
            player.texto.text = "press F to interact";
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ScriptAnimation player = collision.GetComponent<ScriptAnimation>();
        if (player != null)
        {
            player.texto.gameObject.SetActive(false);
        }
    }

    private void OnMouseEnter()
    {
        ScriptAnimation player =FindObjectOfType<ScriptAnimation>();
        player.texto.gameObject.SetActive(true);
        player.texto.text = "press F to interact";
    }
    private void OnMouseExit()
    {
        ScriptAnimation player = FindObjectOfType<ScriptAnimation>();
        player.texto.gameObject.SetActive(false);
        player.texto.text = "press F to interact";
    }

}
