using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is a simple tool to open/disable the mouse cur
public class MouseCur : MonoBehaviour
{
    public bool isShow=false;
    void Start()
    {
        Cursor.visible = isShow;
    }
}
