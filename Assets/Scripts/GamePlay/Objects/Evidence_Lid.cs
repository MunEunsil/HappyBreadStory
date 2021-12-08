using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HappyBread.GamePlay
{
    public class Evidence_Lid : Interactable
    {
        string Evidence_Sprite;
        public override void Interact()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("evidence_Straw_Lid"));

            GetEvidence();

        }
        protected override void InitEvidence()
        {
            DataManager.Instance.dialogeEvidence = true;
            Evidence_Sprite = "evidence_Straw_Lid";
            Evidence = new Evidence()
            {
                Name = "딸기뚜껑",
                Sprite = "evidence_Straw_Lid",
                Action = () =>
                {
                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("evidence_Straw_Lid"));

                }

            };
            DataManager.Instance.dialogeEvidence = false;
        }
    }
}