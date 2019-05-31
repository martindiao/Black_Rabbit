using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Black_Rabbit
{
    public class simple_switch : MonoBehaviour
    {
        public GameObject[] to_active;
        public GameObject[] to_close;

        public void do_switch()
        {
            foreach (GameObject obj in to_active)
            {
                obj.SetActive(true);
            }
            foreach (GameObject obj in to_close)
            {
                obj.SetActive(false);
            }
        }

        public void revert_it()
        {
            foreach (GameObject obj in to_active)
            {
                obj.SetActive(false);
            }
            foreach (GameObject obj in to_close)
            {
                obj.SetActive(true);
            }
        }
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
