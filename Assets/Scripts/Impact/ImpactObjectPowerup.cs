using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactObjectPowerup : ImpactObject
{
    private GameObject _parent => this.gameObject.transform.parent.gameObject;
    private Powerup _powerup => this.gameObject.GetComponentInParent<Powerup>();

    public override void Impact(ImpactObject other)
    {
        Debug.Log("The gameobject " +gameObject+ " successfully impacted with " + other.ImpactableType );
        
        _powerup.OnImpact(this.ImpactableType, other.ImpactableType);
        
        if (other.ImpactableType == EImpactableType.ObjectKiller)
        {
            if(_parent) ObjectPooler.Instance.Despawn(_parent);
        }
    }
}