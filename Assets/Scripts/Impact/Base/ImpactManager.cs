using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;


public class ImpactManager : Singleton<ImpactManager>
{
    public Dictionary<EImpactableType, List<EImpactableType>> ImpactRules = new Dictionary<EImpactableType, List<EImpactableType>>();

    private List<ImpactAction> _impactActions;

    public void ExecuteAction(Impactable sender, Impactable impactedObject)
    {
        foreach (var action in _impactActions)
        {
            if(action.KeyType == sender.ObjectImpactType)
                action.Execute(sender, impactedObject);
        }
    }

    private void Start()
    {
        InitializeImpactActions();
        
        // Debug foreach. Can be removed after it's working for sure.
        foreach (var dictItem in ImpactRules)
        {
            Debug.Log("Dictionary key: " + dictItem.Key + " value: " + dictItem.Value);
        }
    }

    private void InitializeImpactActions()
    {
        _impactActions = new List<ImpactAction>(GetComponents<ImpactAction>());
        
        foreach (var action in _impactActions)
        {
            ImpactRules[action.KeyType] = action.ImpactableTypes;
        }
    }
}

