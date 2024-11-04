using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeathCollectible : MonoBehaviour
{


void OnTriggerEnter2D(Collider2D other)
{
   PlayerController controller = other.GetComponent<PlayerController>();


   if (controller != null && controller.currentHealth < controller.maxHealth)
   {
       controller.ChangeHealth(1);
       Destroy(gameObject);
   }
}
}