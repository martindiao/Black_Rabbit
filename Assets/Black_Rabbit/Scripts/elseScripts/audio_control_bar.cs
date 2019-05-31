using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Black_Rabbit
{
    public class audio_control_bar : MonoBehaviour
    {

        public SoundControl sc;
        public Button pre, after, play_pause;
        public Slider volume;
        private float currentVolume;
        // Start is called before the first frame update

        void Start()
        {
            currentVolume = volume.value;
            //sc.setVolume(currentVolume);
            pre.onClick.AddListener(sc.PreSong);
            after.onClick.AddListener(sc.NextSong);
            play_pause.onClick.AddListener(sc.SwitchState);
        }

        // Update is called once per frame
        void Update()
        {
            if (currentVolume != volume.value)
            {
                currentVolume = volume.value;
                sc.SetVolume(currentVolume);
            }
        }
    }
}

