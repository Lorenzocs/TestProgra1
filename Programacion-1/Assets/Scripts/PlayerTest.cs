using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    public float speed;
    public GameObject bullet;
    public Transform pointGun;
    public GameManager gameManager;
   
   
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.win == true)
        {
            return;
        }

        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalMovement, verticalMovement);
        transform.position += movement * speed * Time.deltaTime;


        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePosition - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));


        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    public void Shoot()
    {

        Instantiate(bullet, pointGun.position, pointGun.rotation);
    }
}
