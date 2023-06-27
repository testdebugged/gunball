using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    public Text timerText;

    private float elapsedTime = 0f;
    private bool isRunning = false;
	

    void Start()
    {
    	StartStopWatch();
    }
    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
            UpdateTimerUI();
        }
    }

    public void StartStopWatch()
    {
        isRunning = true;
    }

    public void StopStopWatch()
    {
        isRunning = false;
    }

    public void ResetStopWatch()
    {
        elapsedTime = 0f;
        UpdateTimerUI();
    }

    private void UpdateTimerUI()
    {
        float minutes = Mathf.FloorToInt(elapsedTime / 60);
        float seconds = Mathf.FloorToInt(elapsedTime % 60);
        float milliseconds = Mathf.FloorToInt(elapsedTime * 1000) % 1000;

        timerText.text = string.Format("{0:00}\"{1:00}.{2:000}", minutes, seconds, milliseconds);
    }
}
