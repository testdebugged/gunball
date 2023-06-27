using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    private bool isOpen;
    public Animator doorAnimator;

    void Start()
    {
    	doorAnimator.enabled = false;
    }
    public void OpenDoor()
    {
        if (!isOpen)
        {
            Debug.Log("Your wish is my command");
            doorAnimator.enabled = true;
            doorAnimator.SetTrigger("OpenDoor");
            
        }
    }
}
