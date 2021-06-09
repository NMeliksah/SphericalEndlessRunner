using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class ImpactObject : MonoBehaviour, IImpactable
{
    public EImpactableType ImpactableType;
    public List<EImpactableType> ImpactableTypes;

    public event Action<EImpactableType, EImpactableType> OnImpact;

    private void Start()
    {
        OnImpact = delegate(EImpactableType sender, EImpactableType other) {  };
    }

    public virtual void Impact(ImpactObject other)
    {
    }
    
    private void OnCollisionEnter(Collision other)
    {
        try
        {
            ImpactObject otherImpactObject = other.gameObject.GetComponent<ImpactObject>();
            if (ImpactableTypes.Contains(otherImpactObject.ImpactableType))
            {
                Impact(otherImpactObject);
                OnImpactInvoker(ImpactableType, otherImpactObject.ImpactableType);
            }
        }
        catch (Exception exception)
        {
            Debug.Log("Collided with " + other.gameObject + " without Impactable. Exception: " + exception);
            return;
        }
    }

    private void OnImpactInvoker(EImpactableType sender, EImpactableType other)
    {
        OnImpact?.Invoke(sender, other);
    }
}

public interface IImpactable
{
    public void Impact(ImpactObject other);
}