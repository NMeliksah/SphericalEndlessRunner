using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    public bool MovementEnabled;

    [SerializeField] private float _movementSpeed;

    private void Update()
    {
        if (MovementEnabled)
        {
            ConstantMovement();
        }
    }

    private void ConstantMovement()
    {
        transform.Translate(transform.forward * (_movementSpeed * Time.deltaTime));
    }
}