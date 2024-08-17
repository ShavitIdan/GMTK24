using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ComponentBox : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void AddComponent(GameObject component)
    {
        Vector2 pos = (Vector2)transform.position + Random.insideUnitCircle;
       // component.transform.SetParent(this.gameObject.transform, true);
       Sequence s = DOTween.Sequence();

       s.Append(component.transform.DOMove(pos, 1f).SetEase(Ease.OutSine));
       s.Join(component.transform.DOScale(new Vector3(.2f, .2f, 0f), 1f).SetDelay(.3f));
       s.Play();
    }
}
