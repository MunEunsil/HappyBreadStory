using HappyBread.ETC;
using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class B1DoorDialogueEvent : Event
    {
        public string FileName { private get; set; }

        public B1DoorDialogueEvent(string filename)
        {
            FileName = filename;
        }
        protected override void BeginDetail()
        {
            GameModel.Instance.StateManager.ChangeState(new DialogueState());
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
            //GameModel.Instance.StateManager.UndoState();
            GameModel.Instance.StateManager.ChangeState(new PlayingState());
            GameModel.Instance.EffectManager.FadeIn();
            GameModel.Instance.AudioManager.PlayEffectAudio("door");
            GameModel.Instance.Player.transform.position = new Vector3(2.94f, -0.78f, 1);

        }

    }
}
