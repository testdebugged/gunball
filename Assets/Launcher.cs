using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Launcher : MonoBehaviour
{
    public Rigidbody tagBall;
    public float launchSpeed;
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            Vector3 direction = transform.right;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Vector3 velocity = direction.normalized * launchSpeed;
            tagBall.velocity = velocity;
            tagBall.transform.eulerAngles = new Vector3(0, 0, angle);
        }
    }
}
