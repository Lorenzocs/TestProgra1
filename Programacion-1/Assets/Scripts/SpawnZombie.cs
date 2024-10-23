using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnZombie : MonoBehaviour
{
    public float timeToSpawn;
    public BasicEnemy enemy;
    public PlayerTest player;
    public int amountEnemies;
    public float radious;
    private float currentTime;


    void Start()
    {
        player = FindObjectOfType<PlayerTest>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        if (distance < radious)
        {
            if (amountEnemies < 4)
            {
                if (currentTime > timeToSpawn)
                {
                    //spawn
                    print("SPAWN");
                    Spawn();
                    currentTime = 0;
                }
                else
                {
                    currentTime += Time.deltaTime;
                }
            }
        }
    }

    public void Spawn()
    {
        BasicEnemy zombie = Instantiate(enemy, transform.position, transform.rotation);
        //zombie.GetComponent<BasicEnemy>().mySpawn = this;
        zombie.mySpawn = this;
        amountEnemies++;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radious);
    }
}
