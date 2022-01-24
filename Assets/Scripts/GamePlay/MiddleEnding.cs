using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using HappyBread.ETC;
using HappyBread.GamePlay.GameState;
using UnityEngine.SceneManagement;

namespace HappyBread.GamePlay
{
    public class MiddleEnding : MonoBehaviour
    {
        /// <summary>
        /// 중간엔딩을 관리하는 씬 
        /// </summary>
        /// 

        //나중에 엔딩모음 만들 때 수정 필요 
        public GameObject endingImage;
        public KeyCode NextCommand;
        private int date;

        public void Start()
        {
            date = DataManager.Instance.date;
            string MImage = DataManager.Instance.middleEndingName;
            endingImage.GetComponent<Image>().sprite = ResourceLoader.LoadSprite(MImage);
            
        }


        private void Update()
        {
            ////keyMiddleEndingExit 

            if (NextCommand != KeyCode.None)
            {
                if (NextCommand == KeyCode.Space)
                {
                    Debug.Log("중간엔딩 state 에서 스페이스바 누름 ");
                    NextCommand = KeyCode.None;

                    SceneManager.LoadScene("Opening", LoadSceneMode.Additive);
                    SceneManager.UnloadSceneAsync("Player");
                   // SceneManager.
                    GameModel.Instance.MiddleEnding.gameObject.SetActive(false);

                    //엔딩 저장하기 
                    GameModel.Instance.DataController.Save_Ending();

                    DataManager.Instance.cake = 0;
                    DataManager.Instance.choco = 0;
                    DataManager.Instance.crois = 0;
                    DataManager.Instance.donut = 0;
                    DataManager.Instance.hodu = 0;
                    DataManager.Instance.jam = 0;

                    DataManager.Instance.jelly = 0;
                    DataManager.Instance.jellyjelly = 0;
                    DataManager.Instance.maca = 0;

                    DataManager.Instance.pancake = 0;
                    DataManager.Instance.straw = 0;
                    DataManager.Instance.twist = 0;




                }

            }


        }


        //중간엔딩을 불러오기 위한 함수들 
        //

        public void startMoldEnding() //곰팡이 엔딩 불러오기
        {
            date = DataManager.Instance.date;
            SceneManager.UnloadSceneAsync($"Map{date}_1");
            GameModel.Instance.AudioManager.ChangeBackgroundAudio("중간엔딩음악");
           
            DataManager.Instance.middleEndingName = "middleEnding2";
            GameModel.Instance.StateManager.ChangeState(new MiddleEndingState());

            //ui뿅 
            GameModel.Instance.StateManager.ChangeState(new PauseState());
            GameModel.Instance.EffectManager.FadeOut();

             
            DataManager.Instance.ending_[1] = true; 


            Invoke("Ending", 2f);
        }
        private void Ending() 
        {
            GameModel.Instance.MiddleEnding.gameObject.SetActive(true);

            GameModel.Instance.EffectManager.FadeIn(0.2f);
            GameModel.Instance.StateManager.Resume();



        }
        //솜사탕 구름 엔딩
        public void cottonCandyEnding()
        {
            date = DataManager.Instance.date;
            SceneManager.UnloadSceneAsync($"Map{date}_1");
            GameModel.Instance.AudioManager.ChangeBackgroundAudio("중간엔딩음악");
            DataManager.Instance.middleEndingName = "middleEnding5";
            GameModel.Instance.StateManager.ChangeState(new MiddleEndingState());

            //ui뿅 
            GameModel.Instance.StateManager.ChangeState(new PauseState());
            GameModel.Instance.EffectManager.FadeOut();


            DataManager.Instance.ending_[4] = true;

            Invoke("Ending", 2f);
        }

        //초코분수 퐁듀 엔딩 
        public void startFondueEnding()
        {
            date = DataManager.Instance.date;
            SceneManager.UnloadSceneAsync($"Map{date}_1");
            GameModel.Instance.AudioManager.ChangeBackgroundAudio("중간엔딩음악");
            DataManager.Instance.middleEndingName = "middleEnding1";
            GameModel.Instance.StateManager.ChangeState(new MiddleEndingState());

            //ui뿅 
            GameModel.Instance.StateManager.ChangeState(new PauseState());
            GameModel.Instance.EffectManager.FadeOut();

            DataManager.Instance.ending_[0] = true;

            Invoke("Ending", 2f);
        }

        //오븐 오버쿡 식빵 엔딩 
        public void startOvenEnding()
        {
            date = DataManager.Instance.date;
            SceneManager.UnloadSceneAsync($"Map{date}_1");
            GameModel.Instance.AudioManager.ChangeBackgroundAudio("중간엔딩음악");
            DataManager.Instance.middleEndingName = "middleEnding4"; //이미지 이름 
            GameModel.Instance.StateManager.ChangeState(new MiddleEndingState());

            //ui뿅 
            GameModel.Instance.StateManager.ChangeState(new PauseState());
            GameModel.Instance.EffectManager.FadeOut();

            DataManager.Instance.ending_[3] = true;

            Invoke("Ending", 2f);
        }

        //냉동고 얼린식빵 엔딩 
        public void startFreezerEnding()
        {
            date = DataManager.Instance.date;
            SceneManager.UnloadSceneAsync($"Map{date}_1");
            GameModel.Instance.AudioManager.ChangeBackgroundAudio("중간엔딩음악");
            DataManager.Instance.middleEndingName = "middleEnding3"; //이미지 이름 
            GameModel.Instance.StateManager.ChangeState(new MiddleEndingState());

            //ui뿅 
            GameModel.Instance.StateManager.ChangeState(new PauseState());
            GameModel.Instance.EffectManager.FadeOut();

            DataManager.Instance.ending_[2] = true;

            Invoke("Ending", 2f);
        }

        //무능한 탐정 엔딩 
        //범인짐녹 시 3번이상 틀려야함
        public void incompetentEnding()
        {

            SceneManager.UnloadSceneAsync($"CallScene");
            GameModel.Instance.AudioManager.ChangeBackgroundAudio("중간엔딩음악");
            DataManager.Instance.middleEndingName = "middleEnding6"; //이미지 이름 
            GameModel.Instance.StateManager.ChangeState(new MiddleEndingState());

            //ui뿅 
            GameModel.Instance.StateManager.ChangeState(new PauseState());
            GameModel.Instance.EffectManager.FadeOut();

            DataManager.Instance.ending_[5] = true;

            Invoke("Ending", 2f);
        }

        //해피엔딩 
        public void totallyHappyEnding()
        {
            GameModel.Instance.AudioManager.ChangeBackgroundAudio("중간엔딩음악");
            DataManager.Instance.middleEndingName = "totallyHappyEnding"; //이미지 이름 
            GameModel.Instance.StateManager.ChangeState(new MiddleEndingState());

            //ui뿅 
            GameModel.Instance.StateManager.ChangeState(new PauseState());
            GameModel.Instance.EffectManager.FadeOut();

            DataManager.Instance.ending_happyEnding[0] = true;

            Invoke("Ending", 2f);
        }

        //배드엔딩
        public void badEnding()
        {
            GameModel.Instance.AudioManager.ChangeBackgroundAudio("중간엔딩음악");
            DataManager.Instance.middleEndingName = "badending"; //이미지 이름 
            GameModel.Instance.StateManager.ChangeState(new MiddleEndingState());

            //ui뿅 
            GameModel.Instance.StateManager.ChangeState(new PauseState());
            GameModel.Instance.EffectManager.FadeOut();

            DataManager.Instance.ending_happyEnding[1] = true;

            Invoke("Ending", 2f);
        }


    }
}
