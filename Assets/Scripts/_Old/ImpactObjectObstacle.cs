using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactObjectObstacle : ImpactObject
{
    private GameObject _parent => this.gameObject.transform.parent.gameObject;

    public override void Impact(ImpactObject other)
    {
        Debug.Log("The gameobject " +gameObject+ " successfully impacted with " + other.ImpactableType );
        
        if (other.ImpactableType == EImpactableType.ObjectKiller)
        {
            if(_parent) ObjectPooler.Instance.Despawn(_parent);
        }
    }
}