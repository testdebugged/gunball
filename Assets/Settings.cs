using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Settings : MonoBehaviour
{
    public Slider sensitivitySlider;
    public Slider volumeSlider;
    public Text volumeText;
    public Text sensitivityText;

    public static float sensitivityValue = 0.5f;
    public static float volumeValue = 100f;
    public GameObject disableMouse;
    public GameObject settingsCanvas;
    private bool isSettingsOpen = false;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            isSettingsOpen = !isSettingsOpen;
            settingsCanvas.SetActive(isSettingsOpen);
            
            if (isSettingsOpen)
            {
            	disableMouse.GetComponent<mouseLook>().enabled = false;
		Cursor.lockState = CursorLockMode.None;
            }
            else
            {
            	disableMouse.GetComponent<mouseLook>().enabled = true;
		Cursor.lockState = CursorLockMode.Locked;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
    
    void Start()
    {
	settingsCanvas.SetActive(false);
        LoadSettings();
        sensitivitySlider.value = sensitivityValue;
        volumeSlider.value = volumeValue;
    }

    public void SaveSettings()
    {
    sensitivityValue = sensitivitySlider.value;
    volumeValue = volumeSlider.value;
    
    PlayerPrefs.SetFloat("Sensitivity", sensitivityValue);
    PlayerPrefs.SetFloat("Volume", volumeValue);

    sensitivityText.text = sensitivityValue.ToString("F2");
    volumeText.text = volumeValue.ToString("F2");

    
    PlayerPrefs.Save();
    }

    private void LoadSettings()
    {
        sensitivityValue = PlayerPrefs.GetFloat("Sensitivity", 0.5f);
        volumeValue = PlayerPrefs.GetFloat("Volume", 0.5f);
    }
}

