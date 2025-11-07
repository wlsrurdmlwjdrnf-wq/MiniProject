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

    private List<MobMoveTo> mobList;
    public List<MobMoveTo> MobList => mobList;

    private void Awake()
    {
        mobList = new List<MobMoveTo>();
        StartCoroutine("SpawnEnemyDelay");
    }
    private void Update()
    {
        if (UIManager.ins.fieldUnits >= 70 && UIManager.ins.fieldUnits < 90)
        {
            UIManager.ins.fieldUnit.color = Color.yellow;
        }
        else if (UIManager.ins.fieldUnits >= 90)
        {
            UIManager.ins.fieldUnit.color = Color.red;
        }
        else if(UIManager.ins.fieldUnits >= 100)
        {
            GameManager.ins.GameOver();
        }
        else
        {
            UIManager.ins.fieldUnit.color = new Color(0f, 1f, 3f, 1f);
        }
    }
    private IEnumerator SpawnEnemyDelay()
    {
        yield return new WaitForSeconds(3);
        StartCoroutine("SpawnEnemy");
    }
    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            GameObject mob = Instantiate(Mobprefab);
            UIManager.ins.AddFieldUnit();
            MobMoveTo mobMoveTo = mob.GetComponent<MobMoveTo>();

            mobMoveTo.SetWayPoint(this, wayPoint);
            mobList.Add(mobMoveTo);
            
            yield return new WaitForSeconds(spawnTime);
        }
    }

    public void RemoveMob(MobMoveTo mob)
    {
        mobList.Remove(mob);
        Destroy(mob.gameObject);
    }
}
