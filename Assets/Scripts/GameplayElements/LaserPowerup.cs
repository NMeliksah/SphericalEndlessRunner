using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPowerup : Powerup
{
    protected override void OnPowerupEnable()
    {
        foreach (var laser in GameMaster.Instance.LaserVisualsArray)
        {
            laser.SetLaserState(true);
        }
    }

    protected override void OnPowerupDisable()
    {
        foreach (var laser in GameMaster.Instance.LaserVisualsArray)
        {
            laser.SetLaserState(false);
        }
    }
}
