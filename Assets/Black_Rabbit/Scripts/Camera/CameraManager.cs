using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Black_Rabbit
{
    public class CameraManager : MonoBehaviour
    {
        public SingleCamera PlayerFaceCam;
        public GameObject PlayerFollowCam;

        public SingleCamera[] NPCCameras;

        public void LookAtNPC(int index)
        {
            LeaveEyesOnScene();
            LeaveEyesOnPlayer();
            if (0 <=index && index < NPCCameras.Length)
            {
                foreach (SingleCamera cam in NPCCameras)
                {
                    cam.LeaveEyes();
                }
                NPCCameras[index].WatchMe();
            }
        }

        public void LeaveEyesOnNPCs()
        {
            foreach (SingleCamera cam in NPCCameras)
            {
                cam.LeaveEyes();
            }
        }

        public void LookAtPlayer()
        {
            LeaveEyesOnNPCs();
            LeaveEyesOnScene();
            PlayerFaceCam.WatchMe();
        }

        public void LeaveEyesOnPlayer()
        {
            PlayerFaceCam.LeaveEyes();
        }

        public void LookAtScene()
        {
            LeaveEyesOnNPCs();
            LeaveEyesOnPlayer();
            PlayerFollowCam.SetActive(true);
        }

        public void LeaveEyesOnScene()
        {
            PlayerFollowCam.SetActive(false);
        }
        // Start is called before the first frame update
        private void Awake()
        {
            PlayerFaceCam = FindObjectOfType<Player_N_Camera>().player.GetComponent<SingleCamera>();
            PlayerFollowCam = FindObjectOfType<Player_N_Camera>().follow_cam.gameObject;
        }

        void Start()
        {
            

            NPCGroup gp = FindObjectOfType<NPCGroup>();
            if (gp.CamNPCs != null)
            {
                int length = gp.CamNPCs.Length;
                NPCCameras = new SingleCamera[length];
                for (int i = 0; i < length; i++)
                {
                    NPCCameras[i] = gp.CamNPCs[i].GetComponent<SingleCamera>();
                }
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

