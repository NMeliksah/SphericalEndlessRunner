using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenMovement : MonoBehaviour
{
    public bool MovementEnabled;
    public bool RotatingRight;
    public bool RotatingLeft;
    
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _rotateDuration;
    
    [SerializeField] private Transform _movementTargetTransform;

    private void Update()
    {
        if (!MovementEnabled) return;
        ConstantMovement();
        
        if (RotatingRight)
        {
            transform.DOLocalRotate(transform.rotation.eulerAngles + new Vector3(0, 90.0f, 0),
                _rotateDuration, RotateMode.Fast);
            RotatingRight = false;
        }
        
        if (RotatingLeft)
        {
            transform.DOLocalRotate(transform.rotation.eulerAngles + new Vector3(0, -90.0f, 0),
                _rotateDuration, RotateMode.Fast);
            RotatingLeft = false;
        }
    }
    
    private void ConstantMovement()
     {
         //transform.Translate(transform.forward * );
         transform.DOMove(_movementTargetTransform.position, 1/_movementSpeed);
         
     }
}