using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationDragObj : MonoBehaviour
{
    [SerializeField]
    private GameObject _objSelect;

    public void ShowRotationObj()
    {
        _objSelect.SetActive(true);
    }

    public void HideRotationObj()
    {
        if (_objSelect.activeSelf)
        {
            _objSelect.SetActive(false);
        }
    }
}
