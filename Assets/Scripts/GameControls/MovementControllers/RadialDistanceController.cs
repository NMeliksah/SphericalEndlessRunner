using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialDistanceController : MonoBehaviour
{
    [SerializeField] private float _minDistance = 0.25f;
    [SerializeField] private float _maxDistance = 4.0f; 
    [SerializeField] private  RadialLayoutGroup _radialLayoutGroup = null;
    
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
