using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : Singleton<GameMaster>
{
    public IMovement PlayerMovement => GameObject.FindWithTag("Player").GetComponent<IMovement>();

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
