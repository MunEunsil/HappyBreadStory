using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HappyBread.GamePlay
{
    public class true_room_cctv : Interactable
    {
        public override void Interact()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("true_room_cctv"));

            GetEvidence();

        }
        protected override void InitEvidence()
        {
            DataManager.Instance.dialogeEvidence = true;
            Evidence = new Evidence()
            {
                Sprite = "temp_trueRoomKey",
                Action = () =>
                {
                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("true_room_cctv"));

                }

            };

            //모든 방에서 cctv 발견 가능
            DataManager.Instance.getKnowCctv = true;
        }
    }
}