using HappyBread.ETC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace HappyBread.GamePlay
{
    public class AudioManager : MonoBehaviour
    {
        public GameObject BackgroundAudio;
        public GameObject EffectAudio;
        public GameObject CharacterAudio;


        [Header("효과음")]
        public AudioClip audioWalk; // 걸을 때 효과음
        public AudioClip audioWalk1;
        public AudioClip audioPaper; // 종이 넘어갈 때 효과음
        public AudioClip audioClick; // 클릭했을 때 효과음
        public AudioClip audioEvidence; // 증거 습득 할 때 효과음
        public AudioClip audioNews; //신문소리
        public AudioClip audioDoor; // 문여는 소리


        [Header("말소리")]
        public AudioClip audioPlayer; //플레이어 말소리
        public AudioClip audioCake;   //컵케이크 말소리
        public AudioClip audioChoco;  // 초코소라빵 말소리
        public AudioClip audioCrois; //크로아상 말쇨
        public AudioClip audioDonut; //도넛 말소리
        public AudioClip audioHodu; //호두 말소리
        public AudioClip audioJam; //땅콩잼 말소리
        public AudioClip audioJelly;// 젤리 말소리 
        public AudioClip audioJellyjelly;//젤리젤리 말소리
        public AudioClip audioMaca; //마카롱 말소리
        public AudioClip audioPancake; //팬케이크 말쇨 
        public AudioClip audioStraw; //딸기 말소리
        public AudioClip audioTwist; //꽈배기 말소리

        public Slider BGM_Volume;
        public Slider EFM_Volume;


        private float eftVol = 1;
        private float backVol = 1f;


        private AudioSource backgroundAudioSource;
        private AudioSource effectAudioSource;
        private AudioSource characterAudioSource;


        //private AudioSource openingAudioSource;
        //private AudioSource callAudioSource;

        public void ChangeBackgroundAudio(string name)
        {

            AudioClip audioClip = ResourceLoader.LoadBackgroundAudio(name);
            backgroundAudioSource.clip = audioClip;
            backgroundAudioSource.Play();
        }
        public void D_Audio(string Dname)
        {
            switch (Dname)
            {
                case "D_player":
                    characterAudioSource.clip = audioPlayer;
                    break;
                case "D_cake":
                    characterAudioSource.clip = audioCake;
                    break;
                case "D_choco":
                    characterAudioSource.clip = audioChoco;
                    break;
                case "D_crois":
                    characterAudioSource.clip = audioCrois;
                    break;
                case "D_donut":
                    characterAudioSource.clip = audioDonut;
                    break;
                case "D_hodu":
                    characterAudioSource.clip = audioHodu;
                    break;
                case "D_jam":
                    characterAudioSource.clip = audioJam;
                    break;
                case "D_jelly":
                    characterAudioSource.clip = audioJelly;
                    break;
                case "D_jellyjelly":
                    characterAudioSource.clip = audioJellyjelly;
                    break;
                case "D_maca":
                    characterAudioSource.clip = audioMaca;
                    break;
                case "D_pancake":
                    characterAudioSource.clip = audioPancake;
                    break;
                case "D_straw":
                    characterAudioSource.clip = audioStraw;
                    break;
                case "D_twist":
                    characterAudioSource.clip = audioTwist;
                    break;
                case "door":
                    characterAudioSource.clip = audioDoor;
                    break;
            }
            //이벤트 중이 아닐 때 
            if (DataManager.Instance.stopVoice == false)
            {
                characterAudioSource.Play();
            }

           

        }



        public void PlayEffectAudio(string name)
        {
            switch (name)
            {
                case "walk" :
                    effectAudioSource.clip = audioWalk;
                    break;
                case "door":
                    effectAudioSource.clip = audioDoor;
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
                case "news":
                    effectAudioSource.clip = audioNews;
                    break;


            }
            if (effectAudioSource.isPlaying)
            {
                return;
            }
            else
            {
                effectAudioSource.Play();
              //  effectAudioSource.PlayOneShot();
            }


             
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
            characterAudioSource = CharacterAudio.GetComponent<AudioSource>();

            //ChangeBackgroundAudio("Dance_Of_The_Sugar_Plum_Fairies");
            ChangeBackgroundAudio("오프닝");
            PlayBackgroundAudio();

            BGM_Volume.value = 0.5f;
            EFM_Volume.value = 0.5f;

            backgroundAudioSource.volume = BGM_Volume.value;
        }


        //사운드 설정 조절 

        public void SoundSlider()
        {
            backgroundAudioSource.volume = BGM_Volume.value;

            backVol = BGM_Volume.value;

        }
        public void EFTSlider()
        {
            effectAudioSource.volume = EFM_Volume.value;

            eftVol = EFM_Volume.value;
        }

        private void Update()
        {
            SoundSlider();
            EFTSlider();
        }




    }
}