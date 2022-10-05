using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HappyBread.GamePlay
{
    public class hidden_door : Interactable
    {
        // 히든맵 트루엔딩 달성 조건 
        public override void Interact()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("dial_hidden_ending_door")); // 대충 문 발견했다는 말 나갈지 말지 선택
            List<Event> events = new List<Event>();

            events.Add(new ActionEvent(() => { GameModel.Instance.MiddleEnding.true_HappyEnding(); })); //중간엔딩으로 이동
            events.Add(new ActionEvent(() => {; })); 
            GameModel.Instance.EventManager.AddBlockingEvent(new AnswerEvent(events));
        }

        protected override void InitEvidence()
        {
            
        }

    }
}