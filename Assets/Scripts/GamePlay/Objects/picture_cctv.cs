using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HappyBread.GamePlay
{
    //picture_cctv

    public class picture_cctv : Interactable
    {
        public override void Interact()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("picture_cctv"));

            //GetEvidence();

        }
        protected override void InitEvidence()
        {
            //DataManager.Instance.dialogeEvidence = true;
            //Evidence = new Evidence()
            //{
            //    Sprite = "temp_trueRoomKey",
            //    Action = () =>
            //    {
            //        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("picture_cctv"));

            //    }

            //};

        }
    }

}