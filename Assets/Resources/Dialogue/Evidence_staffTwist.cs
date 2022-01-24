using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace HappyBread.GamePlay
{
    public class Evidence_staffTwist : Interactable
    {
        public override void Interact()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("evidence_staff_twist"));

            GetEvidence();

        }
        protected override void InitEvidence()
        {
            DataManager.Instance.dialogeEvidence = true;
            Evidence = new Evidence()
            {
                Sprite = "민중을이끄는꽈배기",
                Action = () =>
                {
                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("evidence_staff_twist"));

                }

            };
            DataManager.Instance.dialogeEvidence = false;
        }
    }
}