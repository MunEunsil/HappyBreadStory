using HappyBread.Core;
using HappyBread.GamePlay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.Objects
{
    public class TestSelector : Interactable
    {
        public override void Interact()
        {
            GameModel.Instance.dialogueManager.FileName = "stone";
            GameModel.Instance.dialogueManager.ExecuteDialogue();
            GameModel.Instance.questionManager.Test();
        }
    }
}
