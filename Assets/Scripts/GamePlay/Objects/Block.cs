using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class Block : Interactable
    {
        public override void Interact()
        {
            GameModel.Instance.eventManager.AddBlockingEvent(new DialogueEvent("stone"));
            GameModel.Instance.eventManager.AddNonBlockingEvent(new QuestionBoxEvent());
            GameModel.Instance.eventManager.AddBlockingEvent(new DialogueEvent("temp"));
        }
    }
}
