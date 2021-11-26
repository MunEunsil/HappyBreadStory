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


        public void Start()
        {
            int date = DataManager.Instance.date;
            string MImage = DataManager.Instance.middleEndingName;
            endingImage.GetComponent<Image>().sprite = ResourceLoader.LoadSprite(MImage);
            SceneManager.UnloadSceneAsync($"map{date}_1"); //day에 따라 다르게 해야함으로 코드 추가 필요 
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
            DataManager.Instance.middleEndingName = "middleEnding4";
            GameModel.Instance.StateManager.ChangeState(new MiddleEndingState());

            //ui뿅 
            GameModel.Instance.StateManager.ChangeState(new PauseState());
            GameModel.Instance.EffectManager.FadeOut();

            Invoke("Ending", 2f);
        }
        private void Ending() //곰팡이 엔딩
        {

            GameModel.Instance.MiddleEnding.gameObject.SetActive(true);

            GameModel.Instance.EffectManager.FadeIn(0.2f);
            GameModel.Instance.StateManager.Resume();

        }


        //초코분수 퐁듀 엔딩 
        public void startFondueEnding() 
        {
            DataManager.Instance.middleEndingName = "middleEnding2";
            GameModel.Instance.StateManager.ChangeState(new MiddleEndingState());

            //ui뿅 
            GameModel.Instance.StateManager.ChangeState(new PauseState());
            GameModel.Instance.EffectManager.FadeOut();

            Invoke("Ending", 2f);
        }

        //오븐 오버쿡 식빵 엔딩 
        public void startOvenEnding()
        {
            DataManager.Instance.middleEndingName = "middleEnding5"; //이미지 이름 
            GameModel.Instance.StateManager.ChangeState(new MiddleEndingState());

            //ui뿅 
            GameModel.Instance.StateManager.ChangeState(new PauseState());
            GameModel.Instance.EffectManager.FadeOut();

            Invoke("Ending", 2f);
        }

        //냉동고 얼린식빵 엔딩 
        public void startFreezerEnding()
        {
            DataManager.Instance.middleEndingName = "middleEnding6"; //이미지 이름 
            GameModel.Instance.StateManager.ChangeState(new MiddleEndingState());

            //ui뿅 
            GameModel.Instance.StateManager.ChangeState(new PauseState());
            GameModel.Instance.EffectManager.FadeOut();

            Invoke("Ending", 2f);
        }


    }
}
