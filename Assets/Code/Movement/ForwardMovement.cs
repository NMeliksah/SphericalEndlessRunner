using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    public bool MovementEnabled;

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
