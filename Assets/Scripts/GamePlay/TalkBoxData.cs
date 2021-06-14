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
    /// CaseDiary talkBox탭을  관리
    /// npc와 대화가 발생하면 사건수첩의 키워드와 대화를 오픈  
    /// </summary>

    public class TalkBoxData : MonoBehaviour
    {

        //키워드 오픈이 1로 바뀌면 setActive(T) 
        public string[] strawDialogeKeywords = { "straw0", "straw1", "straw2", "straw3", "straw4", "straw5", "straw6", "7", "8" };
        public int[] strawDialogeKeywordsOpen = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public string[] pancakeDialogeKeywords = { "pancake", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string[] cakeDialogeKeywords = { "cake", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string[] croisDialogeKeywords = { "crois", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string[] macaDialogeKeywords = { "maca", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string[] jellyDialogeKeywords = { "jelly", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string[] jamDialogeKeywords = { "jam", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string[] hoduDialogeKeywords = { "hodu", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string[] twistDialogeKeywords = { "twist", "1", "2", "3", "4", "5", "6", "7", "8" };
        
        public string[] chocoDialogeKeywords = { "호두의 비리", "두려움", "2", "3", "4", "5", "6", "7", "8" };
        public string[] donutDialogeKeywords = { "마지막 대화", "호두와 관계", "마카롱 의심", "3", "4", "5", "6", "7", "8"};

        public void checkDialogue(string characterName)
        {
            //대화 했는지 캐릭터 이름을 받아서 확인 
            // day N , 캐릭터, N번째 확인이 아니지. 이름을 바꿔야할수도 있겠다. 이건 ㅇ회의 후 하기로  
            
        }

    }

}