using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ThirdDimensionInteract : MonoBehaviour
{
    [SerializeField] private Image outline;
    [SerializeField] private UnityEvent hoverEvent;
    [SerializeField] private UnityEvent clickEvent;
    [SerializeField] private Color outlineHoverColor;
    private Color defColor;
    private void Start()
    {
        defColor = outline.color;
    }
    private void OnMouseEnter()
    {
        outline.color = outlineHoverColor;
        hoverEvent.Invoke();
    }
    private void OnMouseExit()
    {
        outline.color = defColor;
    }
    private void OnMouseDown()
    {
        clickEvent.Invoke();
    }
}
