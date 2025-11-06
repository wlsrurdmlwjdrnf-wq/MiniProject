using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TowerManager : MonoBehaviour
{
    public static TowerManager ins;

    public int countWater1 = 0;
    public int countWater2 = 0;
    public int countWater3 = 0;
    public int countFire1 = 0;
    public int countFire2 = 0;
    public int countFire3 = 0;
    public int countGrass1 = 0;
    public int countGrass2 = 0;
    public int countGrass3 = 0;
    public int countDark1 = 0;
    public int countDark2 = 0;
    public int countDark3 = 0;

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
