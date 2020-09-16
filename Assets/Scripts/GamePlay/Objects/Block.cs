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
            GameModel.Instance.eventManager.AddBlockingEvent(new DialogueEvent("test"));

            List<Event> events = new List<Event>();
            events.Add(new ActionEvent(() => { Debug.Log("Hello!!!"); }));
            events.Add(new ActionEvent(() => { Debug.Log("I'm!!!"); }));
            events.Add(new ActionEvent(() => { Debug.Log("Jaeha!!!"); }));
            GameModel.Instance.eventManager.AddBlockingEvent(new AnswerEvent(events));
        }
    }
}
