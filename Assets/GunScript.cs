using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{


	public float fireDelay = 0.5f; // Delay 
	private float fireTimer = 0f;
	
	public float damage = 10f;
	public float range = 100f;
	public float impactForce = 30f;
	public Camera fpsCamera;
	public ParticleSystem muzzleFlash;
	public AudioSource gunShot;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
void Update()
{
    
    if (fireTimer <= 0f)
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            
            Shoot();
            fireTimer = fireDelay;
        }
    }
    else
    {
        // maybe add something for another else that indicates delay?
        fireTimer -= Time.deltaTime;
    }
    
   }
    void Shoot()
    {
    RaycastHit hit;
    muzzleFlash.Play();
    gunShot.Play();
    if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, range))
    {
    Debug.Log(hit.transform.name);
    
    Enemy enemy = hit.transform.GetComponent<Enemy>();
    
    
    
    if (enemy != null)
    {
    	enemy.TakeDamage(damage);
    }
    
     if (hit.transform.CompareTag("Button"))
            {
                hit.transform.GetComponent<ButtonScript>().OpenDoor();
                Debug.Log("open seasame");
            }
            
    
    if (hit.rigidbody != null)
    {
    	hit.rigidbody.AddForce(-hit.normal * impactForce);
    	if (hit.transform.name == "SoccerBall")
    	{
    		//hit.rigidbody.AddForce(-hit.normal * impactForce * 4);
    		 Vector3 forceDirection = fpsCamera.transform.forward;
    //forceDirection.y = 0.5f; 
    forceDirection.Normalize();
    
    float forceMagnitude = impactForce * 1f;
    hit.rigidbody.AddForce(forceDirection * forceMagnitude, ForceMode.Impulse);
    	}
    }
    
    //Vector3 recoilRotation = new Vector3(Random.Range(-10f, 10f), Random.Range(-22f, 22f), 0);
    //fpsCamera.transform.localRotation *= Quaternion.Euler(recoilRotation);

   }
}

}
