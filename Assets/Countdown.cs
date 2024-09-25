using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    // Start is called before the first frame update
    float currentTime= 0f;
    float startTime= 10f;
    [SerializeField] TextMeshProUGUI countdownText;
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = "Time Remaining: " +currentTime.ToString("0");
        }
        
     }
}
