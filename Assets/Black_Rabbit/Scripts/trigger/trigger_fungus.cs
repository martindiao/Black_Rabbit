using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

namespace Black_Rabbit
{
    [AddComponentMenu("Black-Rabit/Trigger/Trigger_Fungus")]
    public class trigger_fungus : trigger
    {
        public Flowchart control;
        public string _message="doit";
        public string blockName = "flow";

        override public void Start()
        {
            base.Start();
            control = transform.Find(blockName).GetComponent<Flowchart>();
        }

        private void Update()
        {
            if (control != null)
            {
                if (control.GetComponent<Flowchart>().HasExecutingBlocks() == true)
                {
                    isTalking = true;
                }
                else
                {
                    isTalking = false;
                }
            }
            else
            {
                isTalking = false;
            }



            if (isUseful && Input.GetKeyUp(KeyCode.E))
            {
                if (control != null)
                {
                    control.GetComponent<Flowchart>().SendFungusMessage(_message);
                }
            }
        }
    }

}
