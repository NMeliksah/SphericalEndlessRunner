using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 180;
    private void Update()
    {
        this.transform.Rotate(Vector3.right, _rotationSpeed * Time.deltaTime);
    }
}
