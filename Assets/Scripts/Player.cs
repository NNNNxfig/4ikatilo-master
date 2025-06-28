using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int moveSpeed = 5;
    public int jumpForce;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    public int health = 3;
    public Text healthText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }


        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);


        if (moveInput > 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (moveInput < 0)
        {
            spriteRenderer.flipX = false;
        }
    }

    public void Damage(int damage)
    {
        health -= damage;
        healthText.text = health.ToString();
        if (health <= 0)
        {
            SceneManager.LoadScene(0);
            Coin.coinCount = 0;
        }
    }

}
