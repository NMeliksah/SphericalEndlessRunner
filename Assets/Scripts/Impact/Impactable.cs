using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Impactable : MonoBehaviour
{
    public EImpactableType ObjectImpactType;
    public List<EImpactableType> ImpactAllowedTypes;

    protected abstract void Impact(EImpactableType otherObjectImpactType);

    private void OnCollisionEnter(Collision other)
    {
        try
        {
            if (!other.gameObject.TryGetComponent<Impactable>(out Impactable otherImpactObject))
            {
                Debug.Log("The object " + this.gameObject + " collided with " + other.gameObject +
                          " but it is not of type Impactable.");
                return;
            }
            Impact(otherImpactObject.ObjectImpactType);
        }
        catch (Exception exception)
        {
            Debug.Log("Collided with " + other.gameObject + " without Impactable. Exception: " + exception);
            return;
        }
    }
}