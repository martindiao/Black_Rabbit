﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Black_Rabbit
{
    [AddComponentMenu("Black-Rabit/Trigger/Trigger_Message_UI")]
    [RequireComponent(typeof(CanvasGroup))]
    public class trigger_message : MonoBehaviour
    {
        public Text trigger_title, action_message;
        public string name_str="name", message_str="message";
        public bool isShow;
        private Transform _trigger;

        public void ShowMessage(string Name, string _Message, Transform trigger)
        {
            trigger_title.text = Name;
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
            trigger_title = transform.Find(name_str).GetComponent<Text>();
            action_message = transform.Find(message_str).GetComponent<Text>();
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