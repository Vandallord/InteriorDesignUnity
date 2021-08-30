using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotationObj : MonoBehaviour
{
    [SerializeField]
    private Transform _centerObj;

    [SerializeField]
    private Transform _objCanvas;

  public void RotLeft()
    {
        BottonRotationDragObj.Instance.LeftRotation(gameObject.transform, _centerObj, _objCanvas);
    }

    public void RotRight()
    {
        BottonRotationDragObj.Instance.RightRotation(gameObject.transform, _centerObj, _objCanvas);
    }
}
