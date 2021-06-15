using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public abstract class ImpactAction : MonoBehaviour
{
    public EImpactableType KeyType;
    public List<EImpactableType> ImpactableTypes;
    public abstract void Execute(Impactable sender, Impactable impactedObject);
}