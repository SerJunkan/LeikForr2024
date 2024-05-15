using UnityEngine;

public class Slime : MonoBehaviour
{
    public float moveSpeed = 3f; // Speed of enemy movement
    public float walkTime = 2f; // Time enemy walks in one direction before turning

    private Rigidbody2D rb;
    private float timer;
    private bool facingRight = false; // Initial facing direction of the enemy

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        timer = walkTime; // Start timer
    }

    void Update()
    {
        timer -= Time.deltaTime; // Countdown timer

        if (timer <= 0)
        {
            // Change direction
            Flip();
        }

        // Move enemy
        Vector2 movement = facingRight ? Vector2.right : Vector2.left;
        rb.velocity = movement * moveSpeed;
    }

    void Flip()
    {
        // Reverse the facing direction of the enemy
        facingRight = !facingRight;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);

        // Reset timer
        timer = walkTime;
    }
}