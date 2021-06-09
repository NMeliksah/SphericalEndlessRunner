using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSenderTest : MonoBehaviour
{
    public event Action<EImpactableType> OnTestAction;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnTestAction?.Invoke(EImpactableType.ObjectKiller);
        }
    }
}
