using HappyBread.Core;
using HappyBread.GamePlay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.Objects
{
    public class Block : Interactable
    {
        public override void Interact()
        {
            GameModel.Instance.dialogueManager.FileName = "blocks";
            GameModel.Instance.dialogueManager.ExecuteDialogue();
        }
    }
}
