using UnityEngine;

public class ImpactObstacle : ImpactAction
{
    public override void Execute(Impactable sender, Impactable impactedObject)
    {
        Debug.Log("Obstacle impacted. Sender: " + sender + " Impacted: " +impactedObject);
    }
}