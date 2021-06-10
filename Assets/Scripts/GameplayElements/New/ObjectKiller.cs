using UnityEngine;

public class ObjectKiller : Impactable
{
    protected override void Impact(Impactable impactedObject)
    {
        ObjectPooler.Instance.Despawn(impactedObject.gameObject);
        Debug.Log("Object Killer despawned: " + impactedObject.gameObject);
    }
}
