using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

namespace Black_Rabbit
{
    public class trigger_fungus : trigger
    {
        public Flowchart control;
        public string _message;


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
