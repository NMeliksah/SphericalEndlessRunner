using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Random = UnityEngine.Random;

public class Powerup1 : Collectible
{
    public bool SetRandomPosition;
    public float InitialPositionAngle;
    
    private void Start()
    {
        if (SetRandomPosition)
        {
            InitialPositionAngle = Random.Range(0f, 360.0f);
        }
        SetRadialPosition(InitialPositionAngle);
    }
}