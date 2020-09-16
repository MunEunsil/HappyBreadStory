using HappyBread.ETC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class DialogueEvent : Event
    {
        public string FileName { private get; set; }

        public DialogueEvent(string filename)
        {
            FileName = filename;
        }
        protected override void BeginDetail()
        {
            if (FileName != null)
            {
                GameModel.Instance.dialogue.gameObject.SetActive(true);
                GameModel.Instance.dialogue.Execute(ResourceLoader.LoadText(FileName));
                GameModel.Instance.dialogue.ConnectedEvent = this;
                GameModel.Instance.inputManager.ChangeState(InputManager.State.DialogControl);
            }
            else
            {
                Debug.Log("파일 명이 비어있습니다.");
                End();
            }
        }

        protected override void EndDetail()
        {
            FileName = null;
        }
    }
}
