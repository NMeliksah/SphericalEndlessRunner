using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : Singleton<GameMaster>
{
    private GameObject _player => GameObject.FindWithTag("Player");
    public PlayerCharacter PlayerCharacter => _player.GetComponent<PlayerCharacter>();
    public IMovement PlayerMovement => _player.GetComponent<IMovement>();
    public LaserVisuals[] LaserVisualsArray => _player.GetComponentsInChildren<LaserVisuals>();
    
    // Set LevelData as LevelData => PlayerPrefs.LastLevel or something like that. Get it automatically.
    public LevelDataSO LevelData;

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
