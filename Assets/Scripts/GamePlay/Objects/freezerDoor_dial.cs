using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HappyBread.ETC;

namespace HappyBread.GamePlay
{
    public class freezerDoor_dial : Interactable
    {
        public override void Interact()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("freezer_key"));
        }

        protected override void InitEvidence()
        {
            
        }
    }
}
