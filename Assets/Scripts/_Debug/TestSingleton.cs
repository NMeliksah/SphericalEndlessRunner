using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSingleton : Singleton<TestSingleton>
{

    public void TestFunction()
    {
        Debug.Log("Test function works!");
    }
}
