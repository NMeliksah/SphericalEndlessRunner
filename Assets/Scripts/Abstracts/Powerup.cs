using System.Collections;
using UnityEngine;

[RequireComponent(typeof(RadialLayoutGroup))]
public abstract class Powerup : MonoBehaviour
{
    public float PowerupDuration;
    protected abstract void OnPowerupEnable();
    protected abstract void OnPowerupDisable();

    public void OnImpact(EImpactableType sender, EImpactableType other)
    {
        OnImpactRoutine(sender, other);
    }

    private IEnumerator OnImpactRoutine(EImpactableType sender, EImpactableType other)
    {
        if(sender == EImpactableType.Powerup && 
           (other == EImpactableType.Sphere1 || 
            other == EImpactableType.Sphere2 ||
            other == EImpactableType.Sphere3))
        {
            OnPowerupEnable();
            yield return new WaitForSeconds(PowerupDuration);
            OnPowerupDisable();
        }
    }
}