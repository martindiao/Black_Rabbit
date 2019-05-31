using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace Black_Rabbit
{
    public class TimeLine_Trigger : trigger
    {
        // Start is called before the first frame update
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

