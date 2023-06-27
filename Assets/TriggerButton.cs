using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerButton : MonoBehaviour
{

	public GameObject buttonCalled;
	
	void OnTriggerEnter(Collider other)
	{
		buttonCalled.transform.GetComponent<ButtonScript>().OpenDoor();
	}
   
}
