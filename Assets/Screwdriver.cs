using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using Sequence = DG.Tweening.Sequence;

public class Screwdriver : MonoBehaviour
{
    
    [SerializeField] private String screwdriverHead = "Flathead";
    [SerializeField] private Collider2D tipCollider;
    public UnityEvent<GameObject> onUnscrew;
    private void Awake()
    {
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        Collider2D[] colliders = new Collider2D[2];
        ContactFilter2D contactFilter = new();
        contactFilter.SetLayerMask(LayerMask.GetMask("Interactables"));
        tipCollider.OverlapCollider(contactFilter, colliders);

        foreach (Collider2D col in colliders)
        {
            
            if (col && col.gameObject.CompareTag(screwdriverHead))
            {
                Sequence s = DOTween.Sequence();

                s.Append(col.gameObject.transform.DORotate(new Vector3(0f, 0f, 100f), 0.2f).SetRelative().SetLoops(5, LoopType.Incremental));
                s.Join(col.gameObject.transform.DOScale(new Vector3(.02f, .02f, .02f), 0.2f).SetRelative().SetLoops(5, LoopType.Incremental));
                s.OnComplete(() =>
                {
                    onUnscrew?.Invoke(col.gameObject);
                });
                s.Play();
            }
        }
    }
}
