using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialDistanceController : MonoBehaviour
{
    [SerializeField] private float _minDistance;
    [SerializeField] private float _maxDistance; 
    [SerializeField] private  RadialLayoutGroup _radialLayoutGroup;
    
    public float DistanceChangeSpeed;
    public bool DistanceChangeEnabled;

    
    private void Update()
    {
        if (DistanceChangeEnabled)
        {
            ChangeRadialDistance();
        }
    }

    private void ChangeRadialDistance()
    {
        float axis = Input.GetAxis("Vertical");
        if (axis != 0)
        {
            Debug.Log("Input axis is: " + axis);
            // Change radial distance here
            if (_radialLayoutGroup.Distance < _minDistance)
            {
                _radialLayoutGroup.Distance = _minDistance;
                return;
            }
            if (_radialLayoutGroup.Distance > _maxDistance)
            {
                _radialLayoutGroup.Distance = _maxDistance;
                return;
            }
            _radialLayoutGroup.Distance += axis * DistanceChangeSpeed * Time.deltaTime;
        }
    }
}
