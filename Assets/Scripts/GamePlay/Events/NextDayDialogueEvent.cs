using HappyBread.ETC;
using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HappyBread.GamePlay
{
    public class NextDayDialogueEvent : Event
    {
        /// <summary>
        /// 침대에서 day넘길 때 day밤 이벤트 진행 
        /// </summary>
        // Start is called before the first frame update

        public string FileName { private get; set; }

        public NextDayDialogueEvent(string filename)
        {
            FileName = filename;
        }

        protected override void BeginDetail()
        {
            if (FileName != null)
            {
                GameModel.Instance.EffectManager.FadeIn();
                GameModel.Instance.Dialogue.Execute(ResourceLoader.LoadText(FileName));
                GameModel.Instance.Dialogue.ConnectedEvent = this;

            }
            else
            {
                Debug.Log("파일 명이 비어있습니다.");
                End();
            }

        }

        protected override void EndDetail()
        {
            FileName = null;
            Debug.Log("엔드 디테일뜸?");
            //bed wakeup진행
            WakeUp();

        }


        public void WakeUp()
        {
            //GameModel.Instance.StateManager.ChangeState(new PlayingState());
            ChangeMap();
            DataManager.Instance.floor = 1;
            int date = GameModel.Instance.Date.Current;


            GameModel.Instance.EffectManager.FadeIn();
            GameModel.Instance.StateManager.Resume();

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

            //load 를 위한 data저장 
            GameModel.Instance.DataController.saveGameData();



        }


        private void ChangeMap()
        {
            GameModel.Instance.Date.AddDay(1);
            int date = GameModel.Instance.Date.Current;

            if (date == 5)
            {
                //추리하기 시작!
                GameModel.Instance.AudioManager.StopBackgroundAudio();
                GameModel.Instance.AudioManager.ChangeBackgroundAudio("추리하기");


               // SceneManager.UnloadSceneAsync($"Map{date}_1");

                SceneManager.LoadScene("CallScene", LoadSceneMode.Additive);
                GameModel.Instance.StateManager.ChangeState(new CallState());


            }
            else
            {
                GameModel.Instance.EffectManager.FadeIn();
                //GameModel.Instance.MapManager.ChangeMap($"Map{date}_1");
               // SceneManager.UnloadSceneAsync($"Map{date - 1}_1");
                SceneManager.LoadScene($"Day{date}_event", LoadSceneMode.Additive); //데모버전 수정 $"Day{date}_event" -> Demo



            }


        }


    }
}
