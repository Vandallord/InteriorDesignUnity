using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjColoring : MonoBehaviour
{
    public static ObjColoring Instance;

    [SerializeField]
    private Material _objSelect;

    [SerializeField]
    private Material _objNoSelect;

    public void Awake()
    {
        Instance = this;
    }

    public Material[] ObjSelect()
    {
        return new Material[] { _objSelect };
    }

    public Material[] ObjNoSelect()
    {
        return new Material[] { _objNoSelect };
    }
}
