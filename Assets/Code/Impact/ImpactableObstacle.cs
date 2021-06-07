using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactableObstacle : Impactable
{
    protected override void Impact(Impactable other)
    {
        Debug.Log("The gameobject " +gameObject+ " successfully impacted with " + other.ImpactableType );
    }
}