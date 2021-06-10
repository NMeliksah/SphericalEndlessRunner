using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovement
{
    public void TurnRight();
    public void TurnLeft();
    public void SetMoveSpeed(float moveSpeed);
    public void SetMovementState(bool state);
    public void ConstantMovement();
}
