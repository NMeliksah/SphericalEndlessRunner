using UnityEngine;

public class ImpactSphere2 : ImpactAction
{
    public override void Execute(EImpactableType sender, Impactable impactedObject)
    {
        Debug.Log("Sphere 2 impacted. Sender: " + sender + " Impacted: " +impactedObject);
    }
}