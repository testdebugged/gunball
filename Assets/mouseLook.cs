using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    public static float MouseSensitivity = 100f;
    private float sensitivityValue;
    public Transform playerBody;
    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        ChangeGlobalValues changeGlobalValues = FindObjectOfType<ChangeGlobalValues>();
        sensitivityValue = ChangeGlobalValues.sensitivityValue;
        
    }

    // Update is called once per frame
    void Update()
    {
    	ChangeGlobalValues changeGlobalValues = FindObjectOfType<ChangeGlobalValues>();
        sensitivityValue = ChangeGlobalValues.sensitivityValue;
        // to constantly update it so it can recieve new values.
    	//Debug.Log(sensitivityValue + "user");
        float MouseX = Input.GetAxis("Mouse X") * MouseSensitivity * sensitivityValue * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * sensitivityValue * Time.deltaTime;
        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * MouseX);
    }
}
