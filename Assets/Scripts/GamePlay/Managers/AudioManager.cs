using HappyBread.ETC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class AudioManager : MonoBehaviour
    {
        public GameObject BackgroundAudio;
        public GameObject EffectAudio;

        public AudioClip audioWalk; // 걸을 때 효과음
        public AudioClip audioPaper; // 종이 넘어갈 때 효과음
        public AudioClip audioClick; // 클릭했을 때 효과음
        public AudioClip audioEvidence; // 증거 습득 할 때 효과음





        private AudioSource backgroundAudioSource;
        private AudioSource effectAudioSource;

        //private AudioSource openingAudioSource;
        //private AudioSource callAudioSource;

        public void ChangeBackgroundAudio(string name)
        {

            AudioClip audioClip = ResourceLoader.LoadBackgroundAudio(name);
            backgroundAudioSource.clip = audioClip;
        }

        public void PlayEffectAudio(string name)
        {
            switch (name)
            {
                case "walk" :
                    effectAudioSource.clip = audioWalk;
                    break;
                case "paper":
                    effectAudioSource.clip = audioPaper;
                    break;
                case "click":
                    effectAudioSource.clip = audioClick;
                    break;
                case "evidence":
                    effectAudioSource.clip = audioEvidence;
                    break;
                
            }
            effectAudioSource.Play();

             
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
            effectAudioSource = EffectAudio.GetComponent<AudioSource>();

            //ChangeBackgroundAudio("Dance_Of_The_Sugar_Plum_Fairies");
            ChangeBackgroundAudio("오프닝");
            PlayBackgroundAudio();
        }


    }
}