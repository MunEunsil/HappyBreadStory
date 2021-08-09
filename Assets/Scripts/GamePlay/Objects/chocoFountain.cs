using System.Collections.Generic;
using UnityEngine;
using HappyBread.GamePlay;
using System;
using HappyBread.ETC;

namespace HappyBread.GamePlay
{
    public class chocoFountain : Interactable
    {
        /// <summary>
        /// 초코분수와 상호작용 하는 클래스
        /// </summary>

        public override void Interact()
        {

            if (DataManager.Instance.chocoFondue < 3)
            {
                GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("noneDialogue"));
                DataManager.Instance.chocoFondue = DataManager.Instance.chocoFondue+1;
            }
            else
            {
                //중간엔딩 불러오기 
                GameModel.Instance.MiddleEnding.startFondueEnding();
                //변수 초기화는 엔딩 이후 다시 시작할 때 
            }
            
        }

        protected override void InitEvidence()   //증거X -> 대화 저장 
        {

        }
    }
}
