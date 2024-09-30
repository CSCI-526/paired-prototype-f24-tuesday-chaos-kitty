using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollision : MonoBehaviour
{
    public TextMeshProUGUI winText; // Reference to the "You Win!" Text object
    public string targetTag = "TargetTag"; // Tag of the object that triggers the win condition

    // This method will be called when the player enters a trigger zone
    void OnTriggerEnter(Collider other)
    {
        // Check if the player collided with the object that has the specified tag
        if (other.CompareTag(targetTag))
        {
            // Display the "You Win" message
            winText.gameObject.SetActive(true);
        }
    }
}
