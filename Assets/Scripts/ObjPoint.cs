using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPoint : MonoBehaviour
{
    [SerializeField]
    private bool _wallLeft;

    void OnMouseEnter()
    {
        gameObject.GetComponent<MeshRenderer>().materials = ObjColoring.Instance.ObjSelect();
        ObjTransform.Instance.NewPosDragObj(transform.position, _wallLeft);
    }

    void OnMouseExit()
    {
        gameObject.GetComponent<MeshRenderer>().materials = ObjColoring.Instance.ObjNoSelect();
    }
}
