using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Black_Rabbit
{
    public class decide_isshowOnstart : MonoBehaviour
    {
        public bool isShowOnStart = true;
        // Start is called before the first frame update
        void Start()
        {
            gameObject.SetActive(isShowOnStart);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

