using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RadialLayoutGroup))]
public abstract class Obstacle : MonoBehaviour
{
    private RadialLayoutGroup RadialLayoutGroup => this.GetComponent<RadialLayoutGroup>();
    
    protected void SetRadialPosition(float angle)
    {
        RadialLayoutGroup.StartAngle = angle % 360.0f;
    }
}