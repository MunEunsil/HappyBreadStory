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
        public override void Interact()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("bed"));
            List<Event> events = new List<Event>();
            events.Add(new ActionEvent(
                () =>
                {
                    GameModel.Instance.EffectManager.Fade();
                    GameModel.Instance.Date.AddDay(1);
                    GameModel.Instance.Hp.Set(100f);
                    GameModel.Instance.StateManager.ChangeState(new PauseState());
                    Invoke("Greeting", 3f);
                }
                ));
            events.Add(new ActionEvent(() => { }));
            GameModel.Instance.EventManager.AddBlockingEvent(new AnswerEvent(events));
        }

        protected override void InitEvidence()
        {

        }

        private void Greeting()
        {
            GameModel.Instance.StateManager.Resume();
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("greeting"));
            GameModel.Instance.EventManager.AddBlockingEvent(new ActionEvent(() => { GameModel.Instance.UIManager.BasicUIAppear(); }));   
        }
    }
}
