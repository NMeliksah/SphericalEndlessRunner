using UnityEngine;

public class ImpactActionTest1 : ImpactAction
{
    public override void Execute(Impactable sender, Impactable impactedObject)
    {
        Debug.Log("Impact Action Test 1 worked. Sender: " + sender + " Impacted: " +impactedObject);
    }
}