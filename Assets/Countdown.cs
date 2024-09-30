using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    // Start is called before the first frame update
    float currentTime= 0f;
    float startTime= 20f;
    [SerializeField] TextMeshProUGUI countdownText;
    public Button ReplayButton;
    void Start()
    {
        ReplayButton.gameObject.SetActive(false);
        currentTime = startTime;
        StartCoroutine(StartCountdown());
    }

    // Update is called once per frame
    IEnumerator StartCountdown()
    {
        while (currentTime > 0f)
        {
            countdownText.text = "Time Remaining: " + currentTime.ToString("0");
            yield return new WaitForSeconds(1f);
            currentTime -= 1f;
        }
        countdownText.text = "Times Up";
        ReplayButton.gameObject.SetActive(true);
    }
    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
