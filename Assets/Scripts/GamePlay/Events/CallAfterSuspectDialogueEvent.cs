using HappyBread.ETC;
using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HappyBread.GamePlay
{
    public class CallAfterSuspectDialogueEvent : Event
    {

        public string FileName { private get; set; }

        public CallAfterSuspectDialogueEvent(string filename)
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

            if (CallManager.Instance.solveCase == 3) //모든사건을 해결하면
            {

                GameModel.Instance.EffectManager.FadeIn();

                SceneManager.UnloadSceneAsync("CallScene");

                SceneManager.LoadScene("Ending", LoadSceneMode.Additive);

                //엔딩state
            }
            else
            {
                GameModel.Instance.StateManager.UndoState();
                GameModel.Instance.EffectManager.FadeIn();
            }

        }
    }
}
