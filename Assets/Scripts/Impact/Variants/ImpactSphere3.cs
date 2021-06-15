using UnityEngine;

public class ImpactSphere3 : ImpactAction
{
    public override void Execute(Impactable sender, Impactable impactedObject)
    {
        Debug.Log("Sphere 3 impacted. Sender: " + sender + " Impacted: " +impactedObject);
   
        CheckPowerups(sender, impactedObject);
    }

    private static void CheckPowerups(Impactable sender,Impactable impactedObject)
    {
        if (impactedObject.ObjectImpactType == EImpactableType.Powerup)
        {
            PlayerCharacter player = GameMaster.Instance.Player;
            EPowerupType powerupType = impactedObject.gameObject.GetComponent<PowerupObject>().PowerupType;
            GameMaster.Instance.ActivatePlayerPowerup(player, powerupType);
        }
    }
}