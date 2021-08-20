using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenaTest1 : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;
    [SerializeField] private float JumpForce;
    [SerializeField] private float MovementForce;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //jump
        }
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);

        if (horizontalInput == 0 && verticalInput == 0)
            return;
        
        rb.AddForce(movementDirection * MovementForce * Time.deltaTime);
    }
}