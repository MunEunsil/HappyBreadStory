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
        public bool isActive = false;

        private string fileName;
        public string FileName
        {
            set { fileName = value; }
        }

        public void ExecuteDialogue()
        {
            if (!isActive && fileName != null)
            {
                isActive = true;
                dialogue.gameObject.SetActive(true);
                dialogue.Execute(ResourceLoader.LoadText(fileName));
                GameModel.Instance.inputManager.ChangeState(InputManager.State.DialogControl);
            }
            else
            {
                Debug.Log("이미 다른 대화가 실행 중 입니다.");
            }
        }

        public void QuitDialogue()
        {
            if(isActive)
            {
                GameModel.Instance.inputManager.UndoState(); // Input 관리
                dialogue.gameObject.SetActive(false); // UI 관리
                isActive = false;
                fileName = null;
            }
        }

    }

}