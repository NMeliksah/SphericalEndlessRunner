using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualToggler : MonoBehaviour
{
    public bool IsVisualsEnabled;
    public List<MeshRenderer> VisualIndicators;

    private void OnValidate()
    {
        foreach (var mesh in VisualIndicators)
        {
            mesh.enabled = IsVisualsEnabled;
        }
    }
}