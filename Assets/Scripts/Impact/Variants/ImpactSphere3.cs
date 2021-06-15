using UnityEngine;

public class ImpactSphere3 : ImpactAction
{
    public override void Execute(EImpactableType sender, Impactable impactedObject)
    {
        Debug.Log("Sphere 3 impacted. Sender: " + sender + " Impacted: " +impactedObject);
   
        CheckPowerups(impactedObject);
    }

    private static void CheckPowerups(Impactable impactedObject)
    {
        if (impactedObject.ObjectImpactType == EImpactableType.Powerup)
        {
            EPowerupType powerupType = impactedObject.gameObject.GetComponent<PowerupObject>().PowerupType;
            PlayerCharacter.Instance.ActivatePowerup(powerupType);
        }
    }
}