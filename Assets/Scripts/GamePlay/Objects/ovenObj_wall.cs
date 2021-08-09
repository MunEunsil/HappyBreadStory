using System.Collections.Generic;
using UnityEngine;
using HappyBread.GamePlay;
using System;
using HappyBread.ETC;

namespace HappyBread.GamePlay
{
    public class ovenObj_wall : Interactable
    {
        /// <summary>
        /// 오븐의 오브젝트와 상호작용 하는 클래스
        /// </summary>

        public override void Interact()
        {

            if (DataManager.Instance.ovenEnding < 3) //ovenEnding datamanager에서 추가하기 
            {
                GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("noneDialogue"));
                DataManager.Instance.ovenEnding = DataManager.Instance.ovenEnding + 1;
            }
            else
            {
                //중간엔딩 불러오기 
                GameModel.Instance.MiddleEnding.startOvenEnding();
                //변수 초기화는 엔딩 이후 다시 시작할 때 
            }

        }

        protected override void InitEvidence()   //증거X -> 대화 저장 
        {

        }
    }
}
