using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private Dictionary<EPowerupType, Powerup> _powerups = new Dictionary<EPowerupType, Powerup>();
    
    public void ActivatePowerup(EPowerupType powerupType)
    {
        _powerups[powerupType].Activate();
    }
    
    private void Start()
    {
        InitializePowerups();
    }

    private void InitializePowerups()
    {
        foreach (var powerup in GetComponentsInChildren<Powerup>())
        {
            _powerups.Add(powerup.PowerupType,powerup);
        }
    }
}
