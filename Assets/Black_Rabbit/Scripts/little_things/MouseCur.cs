using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCur : MonoBehaviour
{
    public bool isShow=false;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = isShow;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
