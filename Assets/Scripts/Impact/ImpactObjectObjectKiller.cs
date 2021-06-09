using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactObjectObjectKiller : ImpactObject
{
    public override void Impact(ImpactObject other)
    {
        Debug.Log("The gameobject " +gameObject+ " successfully impacted with " + other.ImpactableType );
    }
}