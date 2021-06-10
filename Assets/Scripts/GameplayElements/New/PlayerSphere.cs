using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSphere : Impactable
{
    protected override void Impact(Impactable impactedObject)
    {
        Debug.Log("PlayerSphere impacted: " + impactedObject.gameObject);
        
        if (impactedObject.gameObject.TryGetComponent(out Powerup impactedPowerup))
        {
            
        }
    }
}
