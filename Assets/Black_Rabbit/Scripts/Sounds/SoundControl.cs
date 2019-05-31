﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Black_Rabbit
{
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

        public void setVolume(float _volume)
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

        public void preSong()
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

        public void nextSong()
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

        private void Start()
        {
            isPlaying = false;
            _audio = this.GetComponent<AudioSource>();
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