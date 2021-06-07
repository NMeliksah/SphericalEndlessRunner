using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private void Start()
    {
        TestSingleton.Instance.TestFunction();
    }
}
