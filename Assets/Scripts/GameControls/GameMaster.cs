using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : Singleton<GameMaster>
{
    public PlayerCharacter Player => GameObject.FindWithTag("Player").GetComponent<PlayerCharacter>();
    public IMovement PlayerMovement => Player.GetComponent<IMovement>();
    
    // Set LevelData as LevelData => PlayerPrefs.LastLevel or something like that. Get it automatically.
    public LevelDataSO LevelData;

    public void ActivatePlayerPowerup(PlayerCharacter player, EPowerupType powerupType)
    {
        player.ActivatePowerup(powerupType);
    }
    private void Start()
    {
        PlayerMovement.SetMovementState(true);
    }

    private void Update()
    {
        // Debug code. Right / Left turns will be triggered by obstacles.
        if(Input.GetKeyDown(KeyCode.Q)) PlayerMovement.TurnLeft();
        if(Input.GetKeyDown(KeyCode.E)) PlayerMovement.TurnRight();
    }
}
