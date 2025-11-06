using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawn : MonoBehaviour
{
    public GameObject waterlv1;
    public GameObject waterlv2;
    public GameObject waterlv3;
    public GameObject firelv1;
    public GameObject firelv2;
    public GameObject firelv3;
    public GameObject grasslv1;
    public GameObject grasslv2;
    public GameObject grasslv3;
    public GameObject darklv1;
    public GameObject darklv2;
    public GameObject darklv3;

    public Transform spawnPoint;

    public void SpawnTower()
    {
        if (UIManager.ins.gold >= 10)
        {
            UIManager.ins.RemoveGold(10);
            int randomVar = Random.Range(1, 100);

            if (randomVar <= 24)
            {
                Instantiate(waterlv1, spawnPoint.position, spawnPoint.rotation);
                TowerManager.ins.countWater1++;
            }
            else if (randomVar > 24 && randomVar <= 48)
            {
                Instantiate(firelv1, spawnPoint.position, spawnPoint.rotation);
                TowerManager.ins.countFire1++;
            }
            else if (randomVar > 48 && randomVar <= 72)
            {
                Instantiate(grasslv1, spawnPoint.position, spawnPoint.rotation);
                TowerManager.ins.countGrass1++;
            }
            else if (randomVar > 72 && randomVar <= 77)
            {
                Instantiate(waterlv2, spawnPoint.position, spawnPoint.rotation);
                TowerManager.ins.countWater2++;
            }
            else if (randomVar > 77 &&  randomVar <= 82)
            {
                Instantiate(firelv2, spawnPoint.position, spawnPoint.rotation);
                TowerManager.ins.countFire2++;
            }
            else if (randomVar > 82 && randomVar <= 87)
            {
                Instantiate(grasslv2, spawnPoint.position, spawnPoint.rotation);
                TowerManager.ins.countGrass2++;
            }
            else if (randomVar > 87 && randomVar <= 89)
            {
                Instantiate(waterlv3, spawnPoint.position, spawnPoint.rotation);
                TowerManager.ins.countWater3++;
            }
            else if (randomVar > 89 && randomVar <= 91)
            {
                Instantiate(firelv3, spawnPoint.position, spawnPoint.rotation);
                TowerManager.ins.countFire3++;
            }
            else if (randomVar > 91 && randomVar <= 93)
            {
                Instantiate(grasslv3, spawnPoint.position, spawnPoint.rotation);
                TowerManager.ins.countGrass3++;
            }
            else if (randomVar > 93 && randomVar <= 97)
            {
                Instantiate(darklv1, spawnPoint.position, spawnPoint.rotation);
                TowerManager.ins.countDark1++;
            }
            else if (randomVar > 97 && randomVar <= 99)
            {
                Instantiate(darklv2, spawnPoint.position, spawnPoint.rotation);
                TowerManager.ins.countDark2++;
            }
            else
            {
                Instantiate(darklv3, spawnPoint.position, spawnPoint.rotation);
                TowerManager.ins.countDark3++;
            }
        }
    }
}
