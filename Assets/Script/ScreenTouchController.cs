using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScreenTouchController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler,IDragHandler
{
    [SerializeField] Image imagePivot;
    private Vector2 touchPosition;
    public Vector2 Direction{get;private set;}
    public void OnPointerDown(PointerEventData eventData)
    {
        touchPosition=eventData.position;
        imagePivot.enabled=true;
        imagePivot.transform.position=touchPosition;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Direction = Vector3.zero;
        imagePivot.enabled=false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        var delta=eventData.position - touchPosition;
        Direction = delta.normalized;
    }
}
