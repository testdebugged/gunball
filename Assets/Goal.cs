
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public GameObject Win;
    public Stopwatch stopwatch;

    void Start()
    {
        Win.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goal") && other.gameObject.name == "SoccerBall")
        {    
            Debug.Log("goal");
            Win.SetActive(true);
            stopwatch.StopStopWatch();
            StartCoroutine(WaitForInput());
        }
    }

    IEnumerator WaitForInput()
    {
        Debug.Log("Waiting for input...");
        while (true)
        {
            if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
            {
                SceneManager.LoadScene("Levels");
                break;
            }
            yield return null;
        }
    }
}
