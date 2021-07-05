using HappyBread.ETC;
using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class CallDialogueEvent : Event
    {
        /// <summary>
        /// 추리하기 사건선택 일 때 사용한는 대화 이벤트 클래스
        /// 대화 후 증거수첩을 연다.
        /// </summary>
        public string FileName { private get; set; }

        public CallDialogueEvent(string filename)
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

            //증거 선택 켜기 
            CallManager.Instance.EvidenceDiary.SetActive(true);
            CallManager.Instance.RenderEvidence();
              
        }


    }
}
