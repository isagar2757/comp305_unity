﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boss2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 200;
    public GameObject effect,oil;

   
    public int TakeDamage(int damage)
    {
        
        Invoke("oilRelease",1f);
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
        return health;
    }

   void Die()
   {
       Destroy(gameObject);
       SceneManager.LoadScene("Level3");
   }

    void oilRelease()
    {
       
        // Create a new bullet at “transform.position” 
        // Which is the current position of the ship
        // Quaternion.identity = add the bullet with no rotation
        Instantiate(oil, transform.position, transform.rotation);
    }
}
