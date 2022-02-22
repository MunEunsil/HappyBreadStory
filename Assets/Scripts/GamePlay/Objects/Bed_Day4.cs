using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{

    public class Bed_Day4 : Interactable
    {
        //bed_day4
        // Start is called before the first frame update
        public override void Interact()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("bed_day4"));
        }

        protected override void InitEvidence()
        {
            
        }
    }
}
