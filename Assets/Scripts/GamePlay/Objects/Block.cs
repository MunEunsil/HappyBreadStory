using HappyBread.ETC;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class Block : Interactable
    {
        public override void Interact()
        {
            //List<Event> events = new List<Event>();
            //events.Add(new ActionEvent(() => { Debug.Log("Hello!!!"); }));
            //events.Add(new ActionEvent(() => { Debug.Log("I'm!!!"); }));
            //events.Add(new ActionEvent(() => { Debug.Log("Jaeha!!!"); }));
            //GameModel.Instance.eventManager.AddBlockingEvent(new AnswerEvent(events));

            GameModel.Instance.eventManager.AddBlockingEvent(new DialogueEvent("addEvidence"));
            List<Event> events = new List<Event>();
            events.Add(new ActionEvent(() => { GameModel.Instance.caseDiary.AddEvidence(Evidence); }));
            events.Add(new ActionEvent(() => { }));
            GameModel.Instance.eventManager.AddBlockingEvent(new AnswerEvent(events));
        }

        protected override void InitEvidence()
        {
            Evidence = new Evidence()
            {
                Name="Block",
                Content="정체를 알 수 없는 블록이다.",
                Sprite=ResourceLoader.LoadSprite("stone"),
                Action= () =>
                {
                    
                }
            };
        }
    }
}
