using UnityEngine;

[RequireComponent(typeof(RadialLayoutGroup))]
[RequireComponent(typeof(Impactable))]
public abstract class Powerup : MonoBehaviour
{
    public float PowerupDuration;
    protected abstract void EnablePowerup(float duration);

    private Impactable _impactable => this.GetComponent<Impactable>();

    private void Start()
    {
        _impactable.OnImpact += OnImpact;
    }

    private void OnDestroy()
    {
        _impactable.OnImpact -= OnImpact;
    }
    private void OnImpact(EImpactableType sender, EImpactableType other)
    {
        if(sender == EImpactableType.Powerup && 
           (other == EImpactableType.Sphere1 || 
            other == EImpactableType.Sphere2 ||
            other == EImpactableType.Sphere3))
        {
            EnablePowerup(PowerupDuration);
        }
    }
}