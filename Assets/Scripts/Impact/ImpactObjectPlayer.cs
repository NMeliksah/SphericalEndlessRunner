using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactObjectPlayer : ImpactObject
{
    public override void Impact(ImpactObject other)
    {
        Debug.Log("The gameobject " +gameObject+ " successfully impacted with " + other.ImpactableType );
    }
}
