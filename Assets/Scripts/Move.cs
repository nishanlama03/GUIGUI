using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 speed;
    void Start()
    {
        
    }
      
    // Update is called once per frame
    void Update()
    {
        Vector3 currentSpeed = Vector3.zero;

          if (Input.GetKeyDown(KeyCode.A))
        {
            currentSpeed.x = -speed.x;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            currentSpeed.x = speed.x;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            currentSpeed.z= speed.z;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            currentSpeed.z = -speed.z;
        }
        gameObject.transform.Translate(currentSpeed * Time.deltaTime);
    }
}
