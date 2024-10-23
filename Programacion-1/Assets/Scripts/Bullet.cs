using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    void Update()
    {
        transform.position += direction * Time.deltaTime * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
