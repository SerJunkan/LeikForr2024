using UnityEngine;
using UnityEngine.Tilemaps;

public class TestMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public float jumpCooldown = 0.5f; // Adjust as needed
    public Tilemap groundTilemap;

    private Rigidbody2D rb;
    private float jumpTimer;


    public GemManager gm;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpTimer = jumpCooldown; // Jump is available from the start
    }

    void Update()
    {
        // Movement input
        float horizontalInput = Input.GetAxis("Horizontal");

        // Apply movement to the player
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);

        // Jump input
        if (Input.GetKeyDown(KeyCode.Space) && jumpTimer >= jumpCooldown)
        {
            Jump();
            jumpTimer = 0f; // Reset the jump timer
        }

        // Update jump timer
        jumpTimer += Time.deltaTime;
    }

    void Jump()
    {
        // Apply jump force to the player
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Gem"))
        {
            Destroy(other.gameObject);
            gm.gemCount++;
        }

        if (other.gameObject.CompareTag("Slimmy"))
        {
            gm.healthCount--;
        }
    }
}