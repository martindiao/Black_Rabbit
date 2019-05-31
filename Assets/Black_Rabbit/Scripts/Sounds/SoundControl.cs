using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Black_Rabbit
{
    [AddComponentMenu("Black-Rabit/Sound/SoundController")]
    [RequireComponent(typeof(AudioSource))]
    public class SoundControl : MonoBehaviour
    {
        public AudioClip[] Clips;
        private AudioSource _audio;
        private int index;
        private bool isPlaying;

        public void Stop()
        {
            this.GetComponent<AudioSource>().Stop();
            isPlaying = false;
        }

        public void Play()
        {
            this.GetComponent<AudioSource>().Play();
            isPlaying = true;
        }

        public void SetVolume(float _volume)
        {
            _audio.volume = _volume;
        }

        public void SwitchState()
        {
            if (isPlaying)
            {
                Pause();
            }
            else
            {
                Play();
            }
        }

        public void PreSong()
        {
            if (index > 0)
            {
                Stop();
                index--;
                _audio.clip = Clips[index];
                Play();
            }
            else
            {
                Stop();
                index = Clips.Length - 1;
                _audio.clip = Clips[index];
                Play();
            }
        }

        public void Pause()
        {
            _audio.Pause();
            isPlaying = false;
        }

        public void NextSong()
        {
            if (index < Clips.Length - 1)
            {
                Stop();
                index++;
                _audio.clip = Clips[index];
                Play();
            }
            else
            {
                Stop();
                index = 0;
                _audio.clip = Clips[index];
                Play();
            }
        }

        private void Awake()
        {
            isPlaying = false;
            _audio = this.GetComponent<AudioSource>();
            _audio.playOnAwake = false;
            if (Clips.Length > 0)
            {
                index = 0;
                _audio.clip = Clips[index];

                //audio.Play();
            }

        }


        // Update is called once per frame
        void Update()
        {

        }
    }

}
