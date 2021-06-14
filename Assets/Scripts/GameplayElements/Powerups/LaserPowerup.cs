using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPowerup : Powerup
{
    private LaserVisuals[] LaserVisualsArray => GetComponentsInChildren<LaserVisuals>();
    protected override void OnPowerupEnable()
    {
        foreach (var laser in LaserVisualsArray)
        {
            laser.SetLaserState(true);
        }
    }

    protected override void OnPowerupDisable()
    {
        foreach (var laser in LaserVisualsArray)
        {
            laser.SetLaserState(false);
        }
    }
}
