using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Black_Rabbit
{
    //manage the player and the camera
    [AddComponentMenu("Black-Rabit/Player/Player_And_Camera")]
    public class Player_N_Camera : MonoBehaviour
    {
        public string player_name="player", follow_cam_name= "Look_Player_Cam";
        public GameObject player, follow_cam;
        // Start is called before the first frame update
        void Start()
        {
            player = transform.Find(player_name).gameObject;
            follow_cam = transform.Find(follow_cam_name).gameObject;
        }

        public void PlayerDisable()
        {
            player.SetActive(false);
        }

        public void PlayerEnable()
        {
            player.SetActive(true);
        }

        public void FollowCamDisable()
        {
            follow_cam.SetActive(false);
        }

        public void FollowCamEnable()
        {
            follow_cam.SetActive(true);
        }

        public void EnableAll()
        {
            PlayerEnable();
            FollowCamEnable();
        }

        public void DisableALL()
        {
            PlayerEnable();
            FollowCamEnable();
        }
    }

}
