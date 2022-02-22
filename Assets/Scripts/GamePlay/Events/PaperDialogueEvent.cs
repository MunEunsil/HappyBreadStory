using HappyBread.ETC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class PaperDialogueEvent : Event
    {
        public string FileName { private get; set; }

        public PaperDialogueEvent(string filename)
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
            if (DataManager.Instance.newsnum == 1)
            {
                DataManager.Instance.newsnum = 2;
                Debug.Log("addNum  신문num" + DataManager.Instance.newsnum);
            }
            else
            {
                DataManager.Instance.newsnum = 1;
                Debug.Log("addNum  신문num" + DataManager.Instance.newsnum);
            }
        }
    }
}