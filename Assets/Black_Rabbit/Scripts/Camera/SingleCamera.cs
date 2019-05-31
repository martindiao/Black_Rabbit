using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Black_Rabbit
{
    public class SingleCamera : MonoBehaviour
    {
        public string cameraName = "watch_face";

        public GameObject My_Camera;

        // Start is called before the first frame update
        void Start()
        {
            My_Camera = transform.Find(cameraName).gameObject;
            LeaveEyes();
        }

        public void WatchMe()
        {
            My_Camera.SetActive(true);
        }

        public void LeaveEyes()
        {
            My_Camera.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

