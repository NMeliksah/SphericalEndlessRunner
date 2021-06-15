using UnityEngine;

[RequireComponent(typeof(RadialLayoutGroup))]
[RequireComponent(typeof(Impactable))]
public abstract class Obstacle : PooledObject
{
    private RadialLayoutGroup _radialLayoutGroup => this.GetComponent<RadialLayoutGroup>();
    private Impactable _impactable => this.GetComponent<Impactable>();
    
    protected void SetRadialPosition(float angle)
    {
        _radialLayoutGroup.StartAngle = angle % 360.0f;
    }

    public override void OnObjectSpawn()
    {
        // Set position, rotation
    }

}