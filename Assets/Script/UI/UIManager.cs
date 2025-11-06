using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager ins;
    public TextMeshProUGUI roundCount;
    public TextMeshProUGUI goldCount;
    public TextMeshProUGUI fieldUnit;
    public TextMeshProUGUI elementalAdvantage;
    public TextMeshProUGUI waterlv1;
    public TextMeshProUGUI waterlv2;
    public TextMeshProUGUI waterlv3;
    public TextMeshProUGUI firelv1;
    public TextMeshProUGUI firelv2;
    public TextMeshProUGUI firelv3;
    public TextMeshProUGUI grasslv1;
    public TextMeshProUGUI grasslv2;
    public TextMeshProUGUI grasslv3;
    public TextMeshProUGUI darklv1;
    public TextMeshProUGUI darklv2;
    public TextMeshProUGUI darklv3;
    public int fieldUnits = 0;
    public int gold = 3000;

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
    private void Update()
    {
        UpdateGold(gold);
        UpdateTowerCount();
    }
    public void UpdateRound(int num)
    {
        roundCount.text = num.ToString();
    }
    public void UpdateGold(int num)
    {
        goldCount.text = num.ToString();
    }
    public void AddGold(int num)
    {
        gold += num;
    }
    public void RemoveGold(int num)
    {
        gold -= num;
    }
    public void AddFieldUnit()
    {
        fieldUnits++;
        fieldUnit.text = fieldUnits.ToString() + " / 100";
    }
    public void RemoveUnit()
    {
        fieldUnits--;
        fieldUnit.text = fieldUnits.ToString() + " / 100";
    }
    public void UpdateTowerCount()
    {
        waterlv1.text = TowerManager.ins.countWater1.ToString();
        waterlv2.text = TowerManager.ins.countWater2.ToString();
        waterlv3.text = TowerManager.ins.countWater3.ToString();
        firelv1.text = TowerManager.ins.countFire1.ToString();
        firelv2.text = TowerManager.ins.countFire2.ToString();
        firelv3.text = TowerManager.ins.countFire3.ToString();
        grasslv1.text = TowerManager.ins.countGrass1.ToString();
        grasslv2.text = TowerManager.ins.countGrass2.ToString();
        grasslv3.text = TowerManager.ins.countGrass3.ToString();
        darklv1.text = TowerManager.ins.countDark1.ToString();
        darklv2.text = TowerManager.ins.countDark2.ToString();
        darklv3.text = TowerManager.ins.countDark3.ToString();
    }
    
    public void SetTrueElementalAdvantage(Vector2 pos)
    {
        elementalAdvantage.gameObject.SetActive(true);
        elementalAdvantage.transform.position = pos;
    }

    public void SetFalseElementalAdvantage()
    {
        elementalAdvantage.gameObject.SetActive(false);
    }
}
