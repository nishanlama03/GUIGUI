using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2d : MonoBehaviour
{
    public float speed = 5 ;
     
     public float jumpforce;

     private Rigidbody2D rb;

     



     

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        distancetoGround = GetComponent<Collider2D>().bounds.extents.y;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, distanceToGround + 0.1f);
//        return (Mathf.Abs(rb.velocity.y) < Mathf.Epsilon);
    }
    void FixedUpdate()
    {
        float currentSpeed = 0.0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            currentSpeed -= speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            currentSpeed += speed;
        }

       
        if (Input.GetKey(KeyCode.Space) && (isGrounded || jumpCount < 2))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            
        }

        rb.angularVelocity = Vector3.zero;




    }
}
