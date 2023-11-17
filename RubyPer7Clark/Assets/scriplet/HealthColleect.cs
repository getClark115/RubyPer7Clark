using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthColleect : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D other)
    {
        RudyControls controller = other.GetComponent<RudyControls>();
        if (controller != null)
        {
            if(controller.currentHealth < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            } 
            
        }
    }
}
