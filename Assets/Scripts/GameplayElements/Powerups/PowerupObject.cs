using UnityEngine;

[RequireComponent(typeof(RadialLayoutGroup))]
public class PowerupObject : Impactable
{
    [SerializeField] private EPowerupType _powerupType;
    protected override void Impact(Impactable impactedObject)
    {
        if (impactedObject.ObjectImpactType == EImpactableType.Sphere1 ||
            impactedObject.ObjectImpactType == EImpactableType.Sphere2 ||
            impactedObject.ObjectImpactType == EImpactableType.Sphere3)
        {
            PlayerCharacter.Instance.ActivatePowerup(_powerupType);
        }
    }
}