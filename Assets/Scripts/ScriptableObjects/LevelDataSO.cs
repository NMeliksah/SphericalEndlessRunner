using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "New LevelData")]
public class LevelDataSO : ScriptableObject
{
    public string LevelName;
    public float MoveSpeed;
    public List<GameObject> Tiles;
    public List<GameObject> Obstacles;
    public List<GameObject> Powerups;
}