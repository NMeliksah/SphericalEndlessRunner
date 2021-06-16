using UnityEngine;

[RequireComponent(typeof(RadialLayoutGroup))]
public class Obstacle : PooledObject
{
    private RadialLayoutGroup _radialLayoutGroup => this.GetComponent<RadialLayoutGroup>();
    
    public bool OverrideStartPosition;
    public bool SetRandomPosition;
    public float InitialPositionAngle;
    
    protected void SetRadialPosition(float angle)
    {
        _radialLayoutGroup.StartAngle = angle % 360.0f;
    }

    public override void Init()
    {
        // Object's position and rotation is set when it's spawning from the pool, here we need to set radial position of it.
        // We may want to get this info from gamemanager, or simply set it within the prefabs.
        
        if (!OverrideStartPosition) return;

        if (SetRandomPosition)
        {
            InitialPositionAngle = Random.Range(0f, 360.0f);
        }

        SetRadialPosition(InitialPositionAngle);
    }
}