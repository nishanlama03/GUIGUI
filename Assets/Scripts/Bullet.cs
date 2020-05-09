using System.Collections;
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
       
       //Making the gameObject destroy itself after it reaches 3.0f (lifespan)
           currentLife += Time.deltaTime; //Time.deltaTime:
       
       if (currentLife >= lifeSpan )
       {
           Destroy(gameObject);
  
       }
    }
    private void OnCollisionEnter(Collision collision)
  {
      if (collision.gameObject.CompareTag("Ground"))
    {
          Destroy(gameObject);
    }
     
  }
    
 
      


    

  
   
   
    

}
            
 
       
      
        
   
  
     
    

    
