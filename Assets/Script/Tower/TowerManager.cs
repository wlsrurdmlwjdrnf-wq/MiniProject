using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TowerManager : MonoBehaviour
{
    public static TowerManager ins;

    private Dictionary<int, float> towerStatsWater;
    private void Awake()
    {
        if (ins == null)
        {
            ins = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
