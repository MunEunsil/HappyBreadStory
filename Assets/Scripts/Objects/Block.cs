using HappyBread.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class Block : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            GameModel.Instance.dialogueManager.ExecuteDialogue("blocks");
        }
    }
}
