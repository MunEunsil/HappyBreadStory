using HappyBread.ETC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class AudioManager : MonoBehaviour
    {
        public GameObject BackgroundAudio;
        public GameObject EffectAudioPrefab;

        private AudioSource backgroundAudioSource;
        //private AudioSource openingAudioSource;
        //private AudioSource callAudioSource;

        public void ChangeBackgroundAudio(string name)
        {

            AudioClip audioClip = ResourceLoader.LoadBackgroundAudio(name);
            backgroundAudioSource.clip = audioClip;
        }

        public void PlayEffectAudio(string name)
        {
            // 미구현
        }

        public void PlayBackgroundAudio()
        {
            backgroundAudioSource.Play();
        }

        public void StopBackgroundAudio()
        {
            backgroundAudioSource.Stop();
        }

        private void Start()
        {
            backgroundAudioSource = BackgroundAudio.GetComponent<AudioSource>();
            //ChangeBackgroundAudio("Dance_Of_The_Sugar_Plum_Fairies");
            ChangeBackgroundAudio("오프닝");
            PlayBackgroundAudio();
        }


    }
}