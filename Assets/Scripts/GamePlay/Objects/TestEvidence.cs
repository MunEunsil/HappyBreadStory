using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class TestEvidence : Interactable
    {
        public override void Interact()
        {
            GetEvidence();
        }

        protected override void InitEvidence()
        {
            DataManager.Instance.dialogeEvidence = true;
            Evidence = new Evidence()
            {
                Sprite = "muffin",
                Action = () =>
                {
                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("muffin"));
                    
                }

            };
            DataManager.Instance.dialogeEvidence = false;
        }
    }
}