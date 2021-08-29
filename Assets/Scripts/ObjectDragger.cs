using UnityEngine;
using System.Collections;

public class ObjectDragger : MonoBehaviour
{

    [SerializeField]
    private ObjMode _mode;

    [SerializeField]
    private RotationDragObj _rotationDragObj;

    private Vector3 _screenPoint;
    private Vector3 _offset;

    void OnMouseDown()
    {     
        _screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        _offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _screenPoint.z));

        gameObject.GetComponent<Collider>().enabled = false;
        ObjTransform.Instance.NewBool(true);
        ObjTransform.Instance.NewCoorObj(transform);

        TypeObjController.Instance.ChengeType(_mode);
        ObjTransform.Instance.ChengeTypePlatform(_mode);

        HideRotationObj.Instance.AllHide();
        _rotationDragObj.ShowRotationObj();
    }

    //void OnMouseDrag()
    //{
    //    //		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z-1f);
    //    //		transform.position = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;      
    //}

    void OnMouseUp()
    {
        gameObject.GetComponent<Collider>().enabled = true;
        ObjTransform.Instance.NewBool(false);
        TypeObjController.Instance.AllHide();
    }
}

public enum ObjMode { floor = 0, walls = 1, ceiling = 2 };