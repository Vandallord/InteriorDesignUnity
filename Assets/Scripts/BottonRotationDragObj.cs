using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottonRotationDragObj : MonoBehaviour
{
    public static BottonRotationDragObj Instance;

    private Vector4 _canvasPos; // ?
    private Vector3 _canvasPos2;// del?

    public void Awake()
    {
        Instance = this;
    }

    public void LeftRotation(Transform obj, Transform centerObj, Transform canvasObj)
    {
        Debug.Log(canvasObj.position);

        Rotation(obj, centerObj, canvasObj, -1);
    }

    public void RightRotation(Transform obj, Transform centerObj, Transform canvasObj)
    {
        Rotation(obj, centerObj, canvasObj, 1);
    }

    private void Rotation(Transform obj, Transform centerObj, Transform canvasObj, int invert)
    {
        // баг в старых юнити чтоб его не было надо сделать так
        _canvasPos = canvasObj.position;
        centerObj.parent = null;
        canvasObj.parent = null;
        obj.parent = centerObj;
        centerObj.Rotate(0, 90 * invert, 0);
        obj.parent = null;
        centerObj.parent = obj;
        canvasObj.parent = obj;
        canvasObj.position = _canvasPos;
    }
}
