using UnityEngine;

public class ImpactTile : ImpactAction
{
    public override void Execute(Impactable sender, Impactable impactedObject)
    {
        Debug.Log("Tile impacted. Sender: " + sender + " Impacted: " +impactedObject);
    }
}