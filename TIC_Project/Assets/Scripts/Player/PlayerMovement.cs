using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float speed = 5f;

    public float jumpForce = 7f;



    private Rigidbody2D rb;

    private Vector2 movement;

    private int jumpCount = 0;

    public int maxJumps = 2;

    SpriteRenderer sprite;

    Animator animator;


  

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        
    }

    void Update()
    {
        // Captura a entrada do teclado para movimento horizontal
        movement.x = Input.GetAxisRaw("Horizontal"); // A/D e Setas Esquerda/Direita
        movement.y = 0;

        // Verifica se o jogador pode pular
        if (jumpCount < maxJumps && (Input.GetKeyDown(KeyCode.Space)))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpCount++;
            
        }

        animator.SetBool("B_isWalking", movement.x != 0);

        if (Input.GetMouseButtonDown (0))
        {
            Shoot();
        }
    }

    void FixedUpdate()
    {
        // Move o personagem apenas na horizontal
        rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);

        if (movement.x != 0)
        {
            sprite.flipX = movement.x < 0;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o personagem est� tocando o ch�o
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
        }


    }

    void Shoot()
    {
        animator.SetTrigger("T_Attack");
    }




}