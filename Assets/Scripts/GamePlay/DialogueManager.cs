using HappyBread.Core;
using HappyBread.ETC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace HappyBread.GamePlay
{
    public class DialogueManager : MonoBehaviour
    {
        public Dialogue dialogue;

        public void ExecuteDialogue(string fileName)
        {
            dialogue.gameObject.SetActive(true);
            dialogue.Execute(ResourceLoader.LoadText(fileName));
            GameModel.Instance.inputManager.ChangeState(InputManager.State.DialogControl);
        }

    }

}