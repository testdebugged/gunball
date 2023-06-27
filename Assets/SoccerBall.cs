using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{

	
    public float gravity = 9.81f; 
    	 
    private Rigidbody srb;
    
    // Start is called before the first frame update
    void Start()
    {
        srb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        srb.AddForce(Vector3.down * gravity);
    }
}
