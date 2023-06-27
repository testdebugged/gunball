using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleEnemyMove : MonoBehaviour
{
	 public Transform target;
    public float speed = 5f;
    public float gravity = 9.81f; // Earth gravity
    
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
         transform.LookAt(target);
         
         rb.AddForce(Vector3.forward * speed *Time.deltaTime);
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);

        
        rb.AddForce(Vector3.down * gravity);
        
         //transform.Translate(Vector3.down * enemygravity);
          
    }
}
