using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject Mobprefab;
    [SerializeField]
    private float spawnTime;
    [SerializeField]
    private Transform[] wayPoint;

    private void Awake()
    {
        StartCoroutine("SpawnEnemy");
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            GameObject mob = Instantiate(Mobprefab);
            MobMoveTo mobMoveTo = mob.GetComponent<MobMoveTo>();

            mobMoveTo.SetWayPoint(wayPoint);
            
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
