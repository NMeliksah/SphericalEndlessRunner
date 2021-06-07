using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactablePowerup : Impactable
{
    protected override void Impact(Impactable other)
    {
        Debug.Log("The gameobject " +gameObject+ " successfully impacted with " + other.ImpactableType );
    }
}