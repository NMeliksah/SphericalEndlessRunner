using UnityEngine;

public class ImpactSphere2 : ImpactAction
{
    public override void Execute(Impactable sender, Impactable impactedObject)
    {
        Debug.Log("Sphere 2 impacted. Sender: " + sender + " Impacted: " +impactedObject);
   
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