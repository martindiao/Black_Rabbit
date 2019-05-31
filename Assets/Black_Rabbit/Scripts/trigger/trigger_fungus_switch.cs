using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

namespace Black_Rabbit
{

    [RequireComponent(typeof(simple_switch))]
    public class trigger_fungus_switch : trigger_fungus
    {
        public bool needRevert = false;
        // Update is called once per frame


        void Update()
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
                GetComponent<simple_switch>().Do_switch();
                control.GetComponent<Flowchart>().SendFungusMessage(_message);
            }

        }
    }

}
