using HappyBread.ETC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay { 
public class Call_criminalChoiceEvent : Event
{
        /// <summary>
        /// 추리하기 타살 선택 시 사용한는 대화 이벤트 클래스
        /// </summary>
        public string FileName { private get; set; }

        public Call_criminalChoiceEvent(string filename)
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

            //범인 선택 켜기

            CallManager.Instance.SuspectDiary.SetActive(true);
            //CallManager.Instance.RenderEvidence();

        }
    }
}
