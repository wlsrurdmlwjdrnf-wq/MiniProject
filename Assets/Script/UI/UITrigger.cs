using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class UITrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    //원하는 오브젝트에 스크립트 적용한뒤에 출력하고싶은 text를 인스펙터창에 넣기
    public bool hover = false;
    public TextMeshProUGUI text;
    public void OnPointerEnter(PointerEventData eventData)
    {
        hover = true;
        UIManager.ins.SetTrueElementalAdvantage(Input.mousePosition);
        Debug.Log("감지");
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
