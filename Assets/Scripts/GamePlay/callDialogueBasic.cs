using HappyBread.ETC;
using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class callDialogueBasic : Event
    {
        /// <summary>
        /// 추리하기에서 대화 후 증거제출 없는버전
        /// </summary>
        public string FileName { private get; set; }

        public callDialogueBasic(string filename)
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
            if (CallManager.Instance.solveCase == 3)
            {
                CallManager.Instance.LoadEnding();
            }
        }
    }
}
