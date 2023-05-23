using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private bool isJumping = false;
    private Rigidbody2D rb;
    public GameObject player;

    public float knockbackStrength = 10f;
    private bool isKnockback = false;
    //private PlayerMovement playerMovement;

    public Rigidbody2D rb_enemy;




    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb_enemy = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Horizontal movement
        float moveX = Input.GetAxis("Horizontal") * moveSpeed;
        rb.velocity = new Vector2(moveX, rb.velocity.y);
       
        // Jumping
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }

    }

  



    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Reset jump state when landing on the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            isKnockback = true;
        }


    }

   


}
