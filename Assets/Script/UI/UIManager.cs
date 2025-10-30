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
    public void UpdateRound(int num)
    {
        roundCount.text = num.ToString();
    }
    public void UpdateGold(int num)
    {
        goldCount.text = num.ToString();
    }
    public void UpdateFieldUnit(int num)
    {
        fieldUnit.text = num.ToString() + " / 100";
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
