using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjTransform : MonoBehaviour
{
    public static ObjTransform Instance;

    [SerializeField]
    private Transform _curObj;
    [SerializeField]
    private bool _curObjBool;
    private Vector3 _platformAddPos;
    [SerializeField]
    private bool _wallLeft;
    [SerializeField]
    private bool _modeWall;
    [SerializeField]
    private Vector3[] _posAdd;

    public void Awake()
    {
        Instance = this;
    }

    public void NewPosDragObj(Vector3 pos, bool wall)
    {

        if (_curObjBool)
        {
            if (!_modeWall)
            {
                _curObj.position = pos - _platformAddPos;
            }
            else
            {
                if (wall)
                {
                    _curObj.position = pos - _posAdd[1];
                }
                else
                {
                    _curObj.position = pos - _posAdd[2];
                }
            }
        }
    }

    public void NewBool(bool asd)
    {
        _curObjBool = asd;
    }

    public void NewCoorObj(Transform asd)
    {
        _curObj = asd;
    }

    internal void ChengeTypePlatform(ObjMode _mode)
    {
        switch (_mode)
        {
            case ObjMode.floor:
                _modeWall = false;
                _platformAddPos = _posAdd[0];
                break;
            case ObjMode.walls:
                _modeWall = true;
                break;
            case ObjMode.ceiling:
                _modeWall = false;
                _platformAddPos = _posAdd[3];
                break;
            default:
                break;
        }
    }
}