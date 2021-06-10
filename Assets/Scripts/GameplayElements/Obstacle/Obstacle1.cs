using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Obstacle1 : Obstacle
{
    public bool OverrideStartPosition;
    public bool SetRandomPosition;
    public float InitialPositionAngle;
    
    private void Start()
    {
        if (!OverrideStartPosition) return;
        
        if (SetRandomPosition)
        {
            InitialPositionAngle = Random.Range(0f, 360.0f);
        }
        SetRadialPosition(InitialPositionAngle);
    }

    protected override void Impact(Impactable impactedObject)
    {
        switch (impactedObject.ObjectImpactType)
        {
            case EImpactableType.Sphere1:
                Debug.Log("Obstacle 1 impacted with: " + impactedObject.gameObject);
                break;
            case EImpactableType.Sphere2:
                Debug.Log("Obstacle 1 impacted with: " + impactedObject.gameObject);
                break;
            case EImpactableType.Sphere3:
                Debug.Log("Obstacle 1 impacted with: " + impactedObject.gameObject);
                break;
        }
    }
}