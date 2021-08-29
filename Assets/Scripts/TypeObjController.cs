using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeObjController : MonoBehaviour
{
    public static TypeObjController Instance;

    [SerializeField]
    private GameObject[] PanelTypeObj;

    public void Awake()
    {
        Instance = this;
    }

    public void ChengeType(ObjMode type)
    {
        AllHide();

        switch (type)
        {
            case ObjMode.floor:
                PanelTypeObj[0].SetActive(true);
                break;
            case ObjMode.walls:
                PanelTypeObj[1].SetActive(true);
                break;
            case ObjMode.ceiling:
                PanelTypeObj[2].SetActive(true);
                break;
            default:
                break;
        }       

    }

  public void AllHide()
    {
        foreach (var item in PanelTypeObj)
        {
            if (item.activeSelf)
            {
                item.SetActive(false);
            }
        }
    }
}
