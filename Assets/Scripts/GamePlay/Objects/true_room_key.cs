using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HappyBread.GamePlay
{
    public class true_room_key : Interactable
    {
        public override void Interact()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("temp_trueRoomKey"));

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
                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("temp_trueRoomKey"));

                }

            };

            DataManager.Instance.TrueRoomKey = true;
        }
    }
}