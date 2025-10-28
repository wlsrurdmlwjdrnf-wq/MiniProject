using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TowerType
{
    Water,
    Fire,
    Grass,
    Dark
}
public class TowerManager : MonoBehaviour
{
    public TowerType towerType;
    private float attackPower;
    private float attackSpeed;
    private Dictionary<TowerType, Dictionary<int, float>> towerLvByAtk;
    private void Awake()
    {
        Dictionary<int, float> waterTower = new Dictionary<int, float>
        {
            {1, 10 },
            {2, 50 },
            {3, 200 }
        };
    }


}
