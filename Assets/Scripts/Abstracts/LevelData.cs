using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LevelData : MonoBehaviour
{
    public GameObject FirstTile;
    public GameObject LastTile;
    public List<GameObject> Tiles;
    public List<GameObject> Obstacles;
    public List<GameObject> Powerups;

    public RandomSpawner Spawner;
    
    
}
