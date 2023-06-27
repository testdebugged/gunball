using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   public float health = 50f;
   
   public void TakeDamage (float amount)
   {
   	if (gameObject.name != "SoccerBall")
   	{
   	
   	
   		health -= amount;
   		if (health <= 0f)
   		{
   			Die();
   		}
   	}
   	else
   	{
   		 
         
         Debug.Log("Soccer Ball knockback");
   	}
   }
   
   void Die ()
   {
   	Destroy(gameObject);
   }
}
