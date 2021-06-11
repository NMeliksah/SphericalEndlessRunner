using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

[Serializable]
public class ImpactRule
{
    public EImpactableType KeyType;
    public List<EImpactableType> ImpactableTypes;
}

public class ImpactRuleManager : Singleton<ImpactRuleManager>
{
    public Dictionary<EImpactableType, List<EImpactableType>> ImpactRuleDict = new Dictionary<EImpactableType, List<EImpactableType>>();
    
    [SerializeField][CanBeNull] private List<ImpactRule> RulesList;

    private void OnValidate()
    {
        foreach (var rule in RulesList)
        {
            ImpactRuleDict[rule.KeyType] = rule.ImpactableTypes;
        }
    }

    private void Start()
    {
        foreach (var dictItem in ImpactRuleDict)
        {
            Debug.Log("Dictionary key: " + dictItem.Key + " value: " + dictItem.Value);
        }
    }
}

