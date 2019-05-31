using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace Black_Rabbit
{
    [AddComponentMenu("Black-Rabit/Trigger/Trigger_TimeLine")]
    public class TimeLine_Trigger : trigger
    {
        public PlayableDirector PD;

        // Update is called once per frame
        void Update()
        {
            if (isUseful&&Input.GetKeyUp(KeyCode.E))
            {
                PD.Play();
            }
        }
    }
}

