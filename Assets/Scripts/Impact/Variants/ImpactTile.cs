using UnityEngine;

public class ImpactTile : ImpactAction
{
    public override void Execute(EImpactableType sender, Impactable impactedObject)
    {
        Debug.Log("Tile impacted. Sender: " + sender + " Impacted: " +impactedObject);
    }
}