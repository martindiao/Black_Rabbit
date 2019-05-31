using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Black_Rabbit
{
    //this is used to control the Camera whitch watch the NPC or Player's face
    public class FaceCamera : MonoBehaviour
    {
        public string cameraName = "watch_face";

        public GameObject My_Camera;

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

        void Update()
        {

        }
    }
}

