using HappyBread.GamePlay;
using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HappyBread.GamePlay
{
    public class Bed : Interactable
    {
        // int date = GameModel.Instance.Date.Current;
        public override void Interact()
        {
       
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("bed"));

            List<Event> events = new List<Event>();
            events.Add(new ActionEvent(
                () =>
                {
                    GameModel.Instance.EffectManager.FadeOut();
                    GameModel.Instance.StateManager.ChangeState(new PauseState());
                    Invoke("WakeUp", 2f);
                }
                ));
            events.Add(new ActionEvent(() => { }));
            GameModel.Instance.EventManager.AddBlockingEvent(new AnswerEvent(events));
        }

        protected override void InitEvidence()
        {

        }

        private void WakeUp()
        {
            //GameModel.Instance.StateManager.ChangeState(new PlayingState());
            ChangeMap();
            DataManager.Instance.floor = 1;
            int date = GameModel.Instance.Date.Current;

            
            GameModel.Instance.EffectManager.FadeIn();
            GameModel.Instance.StateManager.Resume();
           // GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent($"BedDay{date}"));
            //GameModel.Instance.EventManager.AddBlockingEvent(new ActionEvent(() => { GameModel.Instance.UIManager.BasicUIAppear(); })); 
            //cake, choco, crois, donut, hodu, jam, jelly, jellyjelly, maca, pancake, straw, twist
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

            //game
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
               

                SceneManager.UnloadSceneAsync($"Map{date - 1}_1");

                SceneManager.LoadScene("CallEvent", LoadSceneMode.Additive);
                GameModel.Instance.StateManager.ChangeState(new CallState());


            }
            else
            {
                GameModel.Instance.EffectManager.FadeIn();
                //GameModel.Instance.MapManager.ChangeMap($"Map{date}_1");
                SceneManager.UnloadSceneAsync($"Map{date-1}_1");
                SceneManager.LoadScene($"Day{date}_event", LoadSceneMode.Additive); //데모버전 수정 $"Day{date}_event" -> Demo
                //GameModel.Instance.MapManager.ChangeMap($"Day{date}_event");


            }


        }
    }
}
