using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RadialLayoutGroup))]
public abstract class Powerup : Impactable
{
    public float PowerupDuration;
    protected abstract void OnPowerupEnable();
    protected abstract void OnPowerupDisable();

    private IEnumerator PowerupEnable()
    {
        OnPowerupEnable();
        yield return null;
    }

    private IEnumerator PowerupDisable()
    {
        OnPowerupDisable();
        yield return null;
    }

    private IEnumerator PowerupRoutine()
    {
           yield return PowerupEnable();
           yield return new WaitForSeconds(PowerupDuration);
           yield return PowerupDisable();
    }

    protected override void Impact(Impactable impactedObject)
    {
        switch (impactedObject.ObjectImpactType)
        {
            case EImpactableType.Sphere1:
                StartCoroutine("PowerupRoutine");
                break;
            case EImpactableType.Sphere2:
                StartCoroutine("PowerupRoutine");
                break;
            case EImpactableType.Sphere3:
                StartCoroutine("PowerupRoutine");
                break;
        }
    }
}