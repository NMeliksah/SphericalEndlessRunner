using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class Impactable : MonoBehaviour
{
    public EImpactableType ImpactableType;
    public List<EImpactableType> ImpactableTypes;

    public Action<EImpactableType, EImpactableType> OnImpact;
    protected abstract void Impact(Impactable other);

    private void OnCollisionEnter(Collision other)
    {
        try
        {
            Impactable otherImpactable = other.gameObject.GetComponent<Impactable>();
            if (ImpactableTypes.Contains(otherImpactable.ImpactableType))
            {
                Impact(otherImpactable);
            }
        }
        catch (Exception exception)
        {
            Debug.Log("Collided with " + other.gameObject + " without Impactable. Exception: " + exception);
            return;
        }
    }
}