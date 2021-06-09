using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactObjectTile : ImpactObject
{
    public override void Impact(ImpactObject other)
    {
        Debug.Log("The gameobject " +gameObject+ " successfully impacted with " + other.ImpactableType );

        if (other.ImpactableType == EImpactableType.ObjectKiller)
        {
            ObjectPooler.Instance.Despawn(this.gameObject);
        }
    }
}