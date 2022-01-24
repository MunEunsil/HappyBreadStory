using HappyBread.ETC;
using HappyBread.GamePlay.GameState;
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
                GameModel.Instance.Dialogue.Execute(ResourceLoader.LoadText(FileName));
                GameModel.Instance.Dialogue.ConnectedEvent = this;

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
           
            GameModel.Instance.EffectManager.FadeIn();
        }
    }
}
