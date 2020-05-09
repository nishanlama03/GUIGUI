﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{   
    
    public float lifeSpan = 3.0f;
    public float currentLife = 0.0f;
    
    // Start is called before the first frame update

    
    void Start()
    {
        currentLife = 0.0f;


    }

    // Update is called once per frame
    void Update()
    {
       
       
           currentLife += 1.0f * Time.deltaTime;
       
       if (currentLife >= lifeSpan )
       {
           Destroy(gameObject);
       }

    

    }

  
   
   
    

}
            
 
       
      
        
   
  
     
    

    
