using UnityEngine;

public class ImpactSphere1 : ImpactAction
{
    public override void Execute(EImpactableType sender, Impactable impactedObject)
    { 
        Debug.Log("Sphere 1 impacted. Sender: " + sender + " Impacted: " +impactedObject);
    }
}
