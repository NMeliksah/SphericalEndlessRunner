using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListenerTest : MonoBehaviour
{
    public EventSenderTest SenderTest;

    private void Start()
    {
        SenderTest.OnTestAction += OnTestAction;
    }

    private void OnDestroy()
    {
        SenderTest.OnTestAction -= OnTestAction;
    }

    private void OnTestAction(EImpactableType obj)
    {
        Debug.Log("Test Action sent with type: " + obj);
    }
}
