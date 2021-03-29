using UnityEngine;
using System.Collections;
using DG.Tweening;

public class DraggingActionsTestReturn : DraggingActionsTest 
{
    private Vector3 savedPos;

    public override void OnStartDrag()
    {
        savedPos = transform.position;
    }

    public override void OnEndDrag()
    {
        //transform.DOMove(savedPos, 1f); //DOMove moves the card back to first param - which is the original spot, 2nd param means duration
        //transform.DOMove(savedPos, 1f).SetEase(Ease.OutBounce, 0.5f, 0.1f); //ease function tells how the card moves
        transform.DOMove(savedPos, 1f).SetEase(Ease.OutQuint);//, 0.5f, 0.1f);
    }

    public override void OnDraggingInUpdate(){}

    protected override bool DragSuccessful()
    {
        return true;
    }
}
