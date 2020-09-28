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
            ChangeBackgroundAudio("background");
            PlayBackgroundAudio();
        }
    }
}