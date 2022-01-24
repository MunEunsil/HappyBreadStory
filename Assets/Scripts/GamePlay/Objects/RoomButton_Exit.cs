using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class RoomButton_Exit : Interactable
    {
        public GameObject DoorObject;

        public override void Interact()
        {
            DoorObject.GetComponent<RoomDoor>().exitButton();
        }

        protected override void InitEvidence()
        {
        }

        
    }
}
