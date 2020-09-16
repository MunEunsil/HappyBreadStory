using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class Block : Interactable
    {
        public override void Interact()
        {
            List<string> temp = new List<string>();
            temp.Add("Hello");
            temp.Add("Hi");
            GameModel.Instance.eventManager.AddBlockingEvent(new DialogueEvent("stone"));
            GameModel.Instance.eventManager.AddNonBlockingEvent(new QuestionBoxEvent(temp));

            List<Event> tempEvent = new List<Event>();
            tempEvent.Add(new DialogueEvent("temp"));
            tempEvent.Add(new DialogueEvent("blocks"));
            GameModel.Instance.eventManager.AddBlockingEvent(new AnswerEvent(tempEvent));
        }
    }
}
