using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactablePowerup : Impactable
{
    private GameObject _parent => this.gameObject.transform.parent.gameObject;
    protected override void Impact(Impactable other)
    {
        Debug.Log("The gameobject " +gameObject+ " successfully impacted with " + other.ImpactableType );
        
        if (other.ImpactableType == EImpactableType.ObjectKiller)
        {
            ObjectPooler.Instance.Despawn(_parent);
        }
    }
}