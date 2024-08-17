using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screwdriver : MonoBehaviour
{
    
    [SerializeField] private String screwdriverHead = "Flathead";
    [SerializeField] private Collider2D tipCollider;

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
                //Temp
                Destroy(col.gameObject);
            }
        }
    }
}
