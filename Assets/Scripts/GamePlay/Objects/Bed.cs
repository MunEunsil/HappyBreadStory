using HappyBread.GamePlay;
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
                    // 1. 날짜를 변경한다.
                    // 2. 페이드 효과를 실행한다.
                    // 3. Hp를 가득채운다.
                    // 4. 다른 이벤트를 작동한다.
                    GameModel.Instance.EffectManager.Fade();
                    GameModel.Instance.UIManager.BasicUIHide();
                    GameModel.Instance.Date.AddDay(1);
                    GameModel.Instance.Hp.Set(100f);
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
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("greeting"));
            GameModel.Instance.EventManager.AddBlockingEvent(new ActionEvent(() => { GameModel.Instance.UIManager.BasicUIAppear(); }));   
        }
    }
}
