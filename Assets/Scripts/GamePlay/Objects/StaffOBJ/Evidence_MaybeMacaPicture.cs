using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HappyBread.GamePlay
{
    public class Evidence_MaybeMacaPicture : Interactable
    {
        public override void Interact()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("evidence_MabyMacaPictrue"));

            GetEvidence();

        }
        protected override void InitEvidence()
        {
            DataManager.Instance.dialogeEvidence = true;
            Evidence = new Evidence()
            {
                Sprite = "막가롱과거사진",
                Action = () =>
                {
                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("evidence_MabyMacaPictrue"));

                }

            };
            DataManager.Instance.dialogeEvidence = false;
        }
    }
}
