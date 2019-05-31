using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Black_Rabbit
{
    public class trigger_message : MonoBehaviour
    {
        public Text trigger_name, action_message;
        public bool isShow;
        private Transform _trigger;

        public void ShowMessage(string Name, string _Message, Transform trigger)
        {
            trigger_name.text = Name;
            action_message.text = _Message;
            _trigger = trigger;
            isShow = true;
        }

        public void HideMessage()
        {
            isShow = false;
        }

        void Start()
        {
            _trigger = null;
            isShow = false;
        }

        void Update()
        {
            if (isShow && _trigger.gameObject.activeInHierarchy == true && _trigger != null && _trigger.parent.GetComponent<trigger>().isTalking == false)
            {
                this.GetComponent<CanvasGroup>().alpha = 1;
                this.transform.position = Camera.main.WorldToScreenPoint(_trigger.transform.position);
            }
            else
            {
                this.GetComponent<CanvasGroup>().alpha = 0;
            }
        }
    }

}
