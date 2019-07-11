using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Hover_Butom_Change_Image : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public bool isThisUseful=true;
    public Sprite Toshow;
    public Image show;
    public void OnPointerEnter(PointerEventData eventData)
    {

        if (isThisUseful)
        {
            show.gameObject.SetActive(true);
            print("In it " + gameObject.name);
            show.sprite = Toshow;
        }
        
        //throw new System.NotImplementedException();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (isThisUseful)
        {
            print("Out it " + gameObject.name);
            show.gameObject.SetActive(false);
        }
        //throw new System.NotImplementedException();
    }

    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
