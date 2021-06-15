using UnityEngine;

public class ImpactSphere3 : ImpactAction
{
    public override void Execute(EImpactableType sender, Impactable impactedObject)
    {
        Debug.Log("Sphere 3 impacted. Sender: " + sender + " Impacted: " +impactedObject);
    }
}