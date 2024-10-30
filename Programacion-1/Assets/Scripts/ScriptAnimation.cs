using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class ScriptAnimation : MonoBehaviour
{
    public float speed;
    public Animator animator;
    public Vector2 movement;
    public Bullet bullet;
    BasicEnemy BasicEnemy;
    public AudioSource audioSource;
    public AudioClip attack;
    public TextMeshProUGUI texto;
    public TextMeshProUGUI vidasTexto;
    public UiController uiController;
    public int lifes;
    public AudioManager audioManager;
    public float lifeBar;
    public float lifeBarMax;


    public float textTime;
    private void Start()
    {
        lifeBarMax = lifeBar;
        BasicEnemy = FindObjectOfType<BasicEnemy>();
        audioSource = Camera.main.GetComponent<AudioSource>();
        texto.color = Color.red;
        texto.text = "Hola";
        uiController = FindObjectOfType<UiController>();
        uiController.UpdateLifes(lifes);
        vidasTexto.text = lifes.ToString();
        uiController.UpdateBar(lifeBar / lifeBarMax);
        audioManager=FindObjectOfType<AudioManager>();
    }

    private void Update()
    {
        if (PauseManager.statePause == true)
        {
            return;
        }
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (movement.y != 0)
        {
            movement.x = 0;
        }
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.magnitude);


        if (movement.x != 0 || movement.y != 0)
        {
            animator.SetFloat("LastMoveX", movement.x);
            animator.SetFloat("LastMoveY", movement.y);
        }
        print(animator.GetFloat("LastMoveY"));

        Vector2 position = transform.position;
        position += movement * speed * Time.deltaTime;
        transform.position = position;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");
            Shoot();

            audioSource.PlayOneShot(attack);//reproduce un audioclip :)
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            texto.color = Color.green;
            texto.text = "Hello world";
            textTime = 5;
            lifeBar -= 60;
            uiController.UpdateBar(lifeBar / lifeBarMax);
        }
        /*
        if (textTime > 0)
        {
            textTime -= Time.deltaTime;
        }
        else
        {
            texto.text = " ";
        }*/
    }

    public void Shoot()
    {
        audioManager.PlaySound("Shoot");
        Vector2 shootDirection = Vector2.zero;

        float moveY = animator.GetFloat("LastMoveY");
        float moveX = animator.GetFloat("LastMoveX");

        if (moveY > 0)
        {
            shootDirection = Vector2.up;
        }
        else if (moveY < 0)
        {
            shootDirection = Vector2.down;
        }
        else if (moveX > 0)
        {
            shootDirection = Vector2.right;
        }
        else if (moveX < 0)
        {
            shootDirection = Vector2.left;
        }

        Bullet myBullet = Instantiate(bullet, transform.position, transform.rotation);
        myBullet.direction = shootDirection;

    }
}