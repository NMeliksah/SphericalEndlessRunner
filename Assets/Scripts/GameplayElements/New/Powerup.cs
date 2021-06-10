using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Powerup : MonoBehaviour
{
    public EPowerupType PowerupType = EPowerupType.None;
    public float PowerupDuration = 3.0f;
    public void Activate()
    {
        IEnumerator powerupRoutine = PowerupRoutine();
        StartCoroutine(powerupRoutine);
    }
    
    protected abstract void OnPowerupEnable();
    protected abstract void OnPowerupDisable();

    private IEnumerator PowerupEnable()
    {
        OnPowerupEnable();
        yield return null;
    }

    private IEnumerator PowerupDisable()
    {
        OnPowerupDisable();
        yield return null;
    }

    private IEnumerator PowerupRoutine()
    {
           yield return PowerupEnable();
           yield return new WaitForSeconds(PowerupDuration);
           yield return PowerupDisable();
    }
}