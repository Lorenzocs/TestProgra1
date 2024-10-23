using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public ScriptAnimation player;
    public SpawnZombie mySpawn;
    public GameManager manager;
    public CircleCollider2D collider;

    public bool stun;
    void Start()
    {
        player = FindObjectOfType<ScriptAnimation>();
        manager = FindObjectOfType<GameManager>();
        collider.enabled = false;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (stun == false)
        {

        Vector3 direction = (player.transform.position - transform.position).normalized;
        transform.position += direction * Time.deltaTime;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Bullet balaPlayer = collision.GetComponent<Bullet>();
        if (balaPlayer != null)
        {
            if (mySpawn != null)
            {
                mySpawn.amountEnemies--;
            }
            manager.kills++;

            Destroy(gameObject);

        }
    }
}
