using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TowerType
{
    Water, Fire, Grass, Dark
}
[CreateAssetMenu(fileName = "TowerData", menuName = "Tower/TowerData")]
public class TowerData : ScriptableObject
{
    public TowerType towerType;
    public List<TowerLevelStats> levelStats;
}
[System.Serializable]
public class TowerLevelStats
{
    public int level;
    public float Damage;
    public float AtkSpeed;
}
