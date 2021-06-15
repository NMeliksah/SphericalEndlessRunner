using UnityEngine;

public class ImpactObjectKiller : ImpactAction
{
    public override void Execute(EImpactableType sender, Impactable impactedObject)
    {
        Debug.Log("Object Killer impacted. Sender: " + sender + " Impacted: " + impactedObject);
    }
}