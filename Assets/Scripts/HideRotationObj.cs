using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideRotationObj : MonoBehaviour
{
    public static HideRotationObj Instance;

    [SerializeField]
    private RotationDragObj[] _objHide;

    void Awake()
    {
        Instance = this;
    }

  public void AllHide()
    {
        foreach (var item in _objHide)
        {
            item.HideRotationObj();
        }
    }
}
