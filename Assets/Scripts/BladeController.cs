using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class BladeController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    //private Vector3 _bladeDragStartedFromPos;
    private float _deltaX;
    private bool _needToMove = false;
    private Vector3 _bladeInitialPosition = new Vector3(0, -2.5f, 0);

    public void OnPointerDown(PointerEventData eventData)
    {
        print("pointer down");
        _needToMove = true;
        //_bladeDragStartedFromPos = transform.localPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!_needToMove) return;
        float chanceScaleOfSizeX = 0.008f;
        float chanceScaleOfSizeY = 0.012f;
        _deltaX = eventData.delta.y;
        transform.localPosition = transform.localPosition + eventData.delta.x * chanceScaleOfSizeX * Vector3.right + eventData.delta.y * chanceScaleOfSizeY * Vector3.up;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        print("pointer up");
        _needToMove = false;
        transform.DOMove(_bladeInitialPosition, 0.3f);
    }
}
