using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GemScript : MonoBehaviour
{
    static int stig;
    public TextMeshProUGUI GemPoints;

    public int scoreValue = 1; // Score value of the collectible

    private void Start()
    {
        SetCountText();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collectible has collided with the player
        if (collision.CompareTag("Player"))
        {
            // Add score or perform any other action

            SetCountText();
            // Destroy the collectible object
            Destroy(gameObject);
        }
    }
        void SetCountText()
    {
        GemPoints.text = "Gems: " + stig.ToString();
    }
}
