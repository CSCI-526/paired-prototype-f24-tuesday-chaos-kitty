using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public float currentTime= 0f;
    public float startTime= 40f;
    public TextMeshProUGUI countdownText;
    public Button ReplayButton;
    void Start()
    {
        ReplayButton.gameObject.SetActive(false);
        currentTime = startTime;
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        while (currentTime > 0f)
        {
            countdownText.color = Color.black;
            countdownText.text = "Time Remaining: " + currentTime.ToString("0");
            yield return new WaitForSeconds(1f);
            currentTime -= 1f;
        }
        Time.timeScale = 0f;
        countdownText.text = "Times Up";
        ReplayButton.gameObject.SetActive(true);
    }
    public void ReplayGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
