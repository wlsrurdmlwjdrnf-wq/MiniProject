using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class UITrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool hover = false;
    public TextMeshProUGUI text;
    public void OnPointerEnter(PointerEventData eventData)
    {
        hover = true;
        UIManager.ins.SetTrueElementalAdvantage(Input.mousePosition);
        Debug.Log("°¨Áö");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hover = false;
        UIManager.ins.SetFalseElementalAdvantage();
    }
    private void Update()
    {
        if (hover)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

            text.transform.position = worldPos;
        }
    }
}
