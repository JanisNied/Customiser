using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, 
    IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rTransform;


    void Start()
    {
        rTransform = GetComponent<RectTransform>();    
    }

    public void OnPointerDown(PointerEventData data)
    {
        
    }

    public void OnBeginDrag(PointerEventData data)
    {
        
    }

    public void OnDrag(PointerEventData data)
    {
        Vector2 mousePosition =
            new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        mousePosition.x =
            Mathf.Clamp(mousePosition.x, 0 + rTransform.rect.width / 2, 
            Screen.width - rTransform.rect.width / 2);

        mousePosition.y =
            Mathf.Clamp(mousePosition.y, 0 + rTransform.rect.height / 2,
            Screen.height - rTransform.rect.height / 2);

        rTransform.position = mousePosition;
    }


    public void OnEndDrag(PointerEventData data)
    {
        
    }
}