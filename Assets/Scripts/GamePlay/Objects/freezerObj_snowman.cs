using System.Collections.Generic;
using UnityEngine;
using HappyBread.GamePlay;
using System;
using HappyBread.ETC;

namespace HappyBread.GamePlay
{
    public class freezerObj_snowman : Interactable
    {
        /// <summary>
        /// 냉동고의 오브젝트와 상호작용 하는 클래스 
        /// </summary>

        public override void Interact()
        {
            Debug.Log(DataManager.Instance.freezerEnding);
            if (DataManager.Instance.freezerEnding < 3) //freezerEnding datamanager에서 추가하기 
            {
                GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("noneDialogue"));
                DataManager.Instance.freezerEnding = DataManager.Instance.freezerEnding + 1;
            }
            else
            {
                //중간엔딩 불러오기 
                GameModel.Instance.MiddleEnding.startFreezerEnding();
                //변수 초기화는 엔딩 이후 다시 시작할 때 
            }

        }

        protected override void InitEvidence()   //증거X -> 대화 저장 
        {

        }
    }
}