using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Black_Rabbit
{
    public class SimpleCameManager : MonoBehaviour
    {

        public GameObject[] Cams;

        public void LookAt(int index)
        {
            CloseAll();
            Cams[index].SetActive(true);
        }

        public void CloseAll()
        {
            foreach (GameObject cam in Cams)
            {
                cam.SetActive(false);
            }
        }
        void Start()
        {
            CloseAll();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

