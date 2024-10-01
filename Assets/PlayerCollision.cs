using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class PlayerCollision : MonoBehaviour
{
    public TextMeshProUGUI winText; 
    public string targetTag = "TargetTag";
    public string obstacleTag = "ObstacleTag";
    private Countdown countdown;

    private void Start()
    {
        countdown = FindObjectOfType<Countdown>();
    }
    void OnCollisionEnter(Collision collision)
    {
        print(countdown);    
        if (collision.gameObject.CompareTag(targetTag))
        {
            winText.gameObject.SetActive(true);
            Time.timeScale = 0f;
            countdown.ReplayButton.gameObject.SetActive(true);
        }
        if (collision.gameObject.CompareTag(obstacleTag))
        {
            countdown.countdownText.color = Color.red;
            countdown.currentTime -= 5f;
        }
    }
}
