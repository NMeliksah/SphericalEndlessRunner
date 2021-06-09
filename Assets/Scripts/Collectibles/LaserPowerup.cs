using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPowerup : Powerup
{
    protected override void EnablePowerup(float duration)
    {
        foreach (var laser in GameMaster.Instance.LaserVisualsArray)
        {
            throw new NotImplementedException();
        }
    }
}
