using HappyBread.ETC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class CallOkBtnDialogueEvent : Event
    {
        /// <summary>
        /// 대화 - 추리하기에서 수첩에서 증거와 텍스트를 고르고 확인 버튼을 누르면 발생하는 대화이벤트
        /// </summary>
        /// 
        public string FileName { private get; set; }

        public CallOkBtnDialogueEvent(string filename)
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

            //if 사고사일 때 타살일 때 
            // 사고사이면 그냥 넘어가고 사건 종료 
            // 타살이면 범인
            if (DataManager.Instance.isSuicide == false) //사고사일때
            {
                //selectStrawCase꺼야함
            }
            else // 타살일 때 
            {
                //범인...텍스트와 함께 선택 창 열려야함 
            }
        }

    }
}
