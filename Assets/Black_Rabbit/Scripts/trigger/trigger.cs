using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Black_Rabbit
{
    
    public enum Trigger_Type
    {
        base_trigger, fungus_trigger, full_trigger, talkable, talkable_with_cam
    }

    [AddComponentMenu("Black-Rabit/Trigger/BasicTrigger")]
    public class trigger : MonoBehaviour
    {
        public Trigger_Type type;

        public Transform messagePos;
        public string PosName = "Message_Pos";

        public string _Name, _Message;
        public trigger_message UI;
        public bool isUseful;
        public bool isTalking = false;
        // Start is called before the first frame update
        public virtual void Start()
        {
            UI = FindObjectOfType<trigger_message>();
            isUseful = false;
            isTalking = false;
            messagePos = transform.Find(PosName);
        }
        protected virtual void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {

                UI.ShowMessage(_Name, _Message, messagePos);
                isUseful = true;
            }
        }

        protected void OnTriggerExit(Collider other)
        {
            if (other.tag == "Player")
            {
                UI.HideMessage();
                isUseful = false;
            }
        }

    }

}
