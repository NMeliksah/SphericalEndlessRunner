using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Impactable : MonoBehaviour
{
    public EImpactableType ObjectImpactType;

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

            if (!ImpactManager.Instance)
            {
                Debug.Log("Impact Rule Manager does not exist in the scene.");
                return;
            }
            
            if(ImpactManager.Instance.ImpactRules[ObjectImpactType].Contains(otherImpactObject.ObjectImpactType))
            {
                ImpactManager.Instance.ExecuteAction(ObjectImpactType, otherImpactObject);
            }
        }
        catch (Exception exception)
        {
            Debug.Log("The object : " + ObjectImpactType + " collided with " + other.gameObject + " but ImpactAction did not trigger. Exception: " + exception);
            return;
        }
    }
}