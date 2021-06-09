using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenMovement : MonoBehaviour, IMovement
{
    private bool _movementEnabled;
    private bool _rotatingRight;
    private bool _rotatingLeft;
    
    [SerializeField] private float _movementSpeed = 5;
    [SerializeField] private float _rotateDuration = 1;
    
    [SerializeField] private Transform _movementTargetTransform = null;

    private void Update()
    {
        ConstantMovement();
    }

    public void TurnRight()
    {
        _rotatingRight = true;
    }

    public void TurnLeft()
    {
        _rotatingLeft = true;
    }

    public void SetMoveSpeed(float moveSpeed)
    {
        _movementSpeed = moveSpeed;
    }

    public void SetMovementState(bool state)
    {
        _movementEnabled = state;
    }

    public void ConstantMovement()
    {
        if (!_movementEnabled) return;
        
        transform.DOMove(_movementTargetTransform.position, 1/_movementSpeed);

        if (_rotatingRight)
        {
            transform.DOLocalRotate(transform.rotation.eulerAngles + new Vector3(0, 90.0f, 0),
                _rotateDuration, RotateMode.Fast);
            _rotatingRight = false;
        }
        
        if (_rotatingLeft)
        {
            transform.DOLocalRotate(transform.rotation.eulerAngles + new Vector3(0, -90.0f, 0),
                _rotateDuration, RotateMode.Fast);
            _rotatingLeft = false;
        }
    }
}