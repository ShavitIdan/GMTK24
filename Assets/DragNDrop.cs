using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDrop : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler 
{
    [SerializeField] private Transform slotTransform;
    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
        
    }

    void Update()
    {

    }

    private void Awake()
    {
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 currentPosition = new(eventData.pointerCurrentRaycast.worldPosition.x,eventData.pointerCurrentRaycast.worldPosition.y,0);
        transform.position = currentPosition;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector3 currentPosition = new(eventData.pointerPressRaycast.worldPosition.x,eventData.pointerPressRaycast.worldPosition.y,0);
        transform.position = Vector3.Lerp(transform.position,currentPosition, 3f * Time.deltaTime);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Vector3 endPosition = Vector2.Distance(transform.position, slotTransform.position) <
                              Vector2.Distance(transform.position, startPosition) ? slotTransform.position : startPosition;
        transform.DOMove(endPosition, 0.5f);
    }

}

