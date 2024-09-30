using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollision : MonoBehaviour
{
    public TextMeshProUGUI winText; 
    public string targetTag = "TargetTag";
    public string obstacleTag = "ObstacleTag";

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            winText.gameObject.SetActive(true);
        }
    }
}
