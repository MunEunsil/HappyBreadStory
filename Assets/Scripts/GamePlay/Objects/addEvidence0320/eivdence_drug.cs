using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class eivdence_drug : Interactable
    {
        string Evidence_Sprite;
        public override void Interact()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("eivdence_drug"));

            GetEvidence();

        }
        protected override void InitEvidence()
        {
            DataManager.Instance.dialogeEvidence = true;
            Evidence = new Evidence()
            {
                Name = "",
                Sprite = "eivdence_drug",
                Action = () =>
                {
                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("eivdence_drug"));

                }

            };
            DataManager.Instance.dialogeEvidence = false;
        }
    }
}