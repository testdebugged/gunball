using UnityEngine;

public class ChangeGlobalValues : MonoBehaviour
{
    public static float volumeValue = 0.5f;
    public static float sensitivityValue = 0.5f;


    void Update()
    {
        sensitivityValue = PlayerPrefs.GetFloat("Sensitivity", 0.5f);
        volumeValue = PlayerPrefs.GetFloat("Volume", 0.5f);
        AudioListener.volume = volumeValue;
    }
}

