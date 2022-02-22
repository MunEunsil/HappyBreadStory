using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//evidence_boosts

namespace HappyBread.GamePlay
{
    public class Evidence_boots : Interactable
    {
        public override void Interact()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("evidence_boosts"));

            GetEvidence();

        }
        protected override void InitEvidence()
        {
            DataManager.Instance.dialogeEvidence = true;
            Evidence = new Evidence()
            {
                Sprite = "evidence_boosts",
                Action = () =>
                {
                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("evidence_boosts"));

                }

            };
            DataManager.Instance.dialogeEvidence = false;
        }
    }
}