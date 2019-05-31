using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Black_Rabbit
{
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

        // Update is called once per frame
        void Update()
        {

        }
    }

}
