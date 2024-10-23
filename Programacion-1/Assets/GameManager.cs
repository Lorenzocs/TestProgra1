using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool win;
    public int kills;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (win == false)
        {
            if (kills >= 8)
            {
                win = true;
                if (win == true)
                {
                    print("GANE!");
                    Time.timeScale = 0.5f;
                }
            }
        }
    }
}
