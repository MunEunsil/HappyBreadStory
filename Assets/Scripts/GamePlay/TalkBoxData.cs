using HappyBread.Core;
using HappyBread.ETC;
using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace HappyBread.GamePlay
{
    /// <summary>
    /// CaseDiary talkBox탭을  관리하는 클래스
    /// </summary>
    
    public class TalkBoxData : MonoBehaviour
    {
        private static TalkBoxData _instance;

        public static TalkBoxData Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = GameObject.Find("TalkBoxData").GetComponent<TalkBoxData>();
                }
                return _instance;
            }
        }

        //키워드 오픈이 1로 바뀌면 setActive(T) 
        public string[] strawDialogeKeywords = { "straw0", "straw1", "straw2", "straw3", "straw4", "straw5", "straw6", "7", "8" };
        public int[] strawDialogeKeywordsOpen = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public string[] pancakeDialogeKeywords = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string[] cakeDialogeKeywords = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string[] croisDialogeKeywords = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string[] macaDialogeKeywords = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string[] jellyDialogeKeywords = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string[] jamDialogeKeywords = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string[] hoduDialogeKeywords = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string[] twistDialogeKeywords = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string[] chocoDialogeKeywords = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string[] donutDialogeKeywords = { "0", "1", "2", "3", "4", "5", "6", "7", "8"};


    }

}