using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactableTile : Impactable
{
    protected override void Impact(Impactable other)
    {
        Debug.Log("The gameobject " +gameObject+ " successfully impacted with " + other.ImpactableType );

        if (other.ImpactableType == EImpactableType.ObjectKiller)
        {
            ObjectPooler.Instance.Despawn(this.gameObject);
        }
    }
}