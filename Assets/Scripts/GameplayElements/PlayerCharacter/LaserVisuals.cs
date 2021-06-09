using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LaserVisuals : MonoBehaviour
{
    [SerializeField] private float _laserDistance = 5000.0f;
    [SerializeField] private bool _laserEnabled = true;
    private LineRenderer _lineRenderer => GetComponent<LineRenderer>();

    public void SetLaserState(bool state)
    {
        _laserEnabled = state;
    }
    
    private void Update()
    {
        LaserActivation();
    }

    private void LaserActivation()
    {
        if (!_laserEnabled) return;

        _lineRenderer.SetPosition(0, transform.position);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider)
            {
                _lineRenderer.SetPosition(1, hit.point);
            }
        }
        else _lineRenderer.SetPosition(1, transform.forward * _laserDistance);
    }
}