using System;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class Impactable : MonoBehaviour
{
    public EImpactableType ObjectImpactType;
    public List<EImpactableType> ImpactAllowedTypes;

    protected abstract void Impact(Impactable impactedObject);

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

            if (ImpactAllowedTypes.Contains(otherImpactObject.ObjectImpactType))
            {
                Impact(otherImpactObject);
            }
        }
        catch (Exception exception)
        {
            Debug.Log("Collided with " + other.gameObject + " without Impactable. Exception: " + exception);
            return;
        }
    }
}