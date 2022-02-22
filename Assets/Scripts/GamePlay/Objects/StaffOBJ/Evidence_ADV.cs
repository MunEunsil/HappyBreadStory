using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//evidence_edvCosmetic

namespace HappyBread.GamePlay
{

    public class Evidence_ADV : Interactable
    {
        public override void Interact()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("evidence_edvCosmetic"));

            GetEvidence();

        }
        protected override void InitEvidence()
        {
            DataManager.Instance.dialogeEvidence = true;
            Evidence = new Evidence()
            {
                Sprite = "evidence_edvCosmetic",
                Action = () =>
                {
                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("evidence_edvCosmetic"));

                }

            };
            DataManager.Instance.dialogeEvidence = false;
        }
    }
}
