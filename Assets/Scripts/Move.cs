using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 speed;

    public float turnSpeed;

    void Start()
    {
        
    }
      

       
    
  
    void Update()
    {
       float currentSpeed = 0.0f;
       float currentTurnAmount = 0.0f;

       if (Input.GetKey(KeyCode.A)) 
       {
           currentTurnAmount -= turnSpeed;
       }
       if (Input.GetKey(KeyCode.D)) 
       {
           currentTurnAmount += turnSpeed;
       }
       if (Input.GetKey(KeyCode.W)) 
       {
           currentSpeed = speed.x;
       }
       if (Input.GetKey(KeyCode.S)) 
       {
           currentSpeed = -speed.x;
       }

        gameObject.transform.Rotate(Vector3.up, currentTurnAmount * Time.deltaTime);
        gameObject.transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);

    }
  }
