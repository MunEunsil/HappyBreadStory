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
        public string[] strawDialogeKeywords = { "성격", "straw1", "straw2", "straw3", "straw4", "straw5", "straw6", "7", "8" };
        public int[] strawDialogeKeywordsOpen = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public string[] pancakeDialogeKeywords = { "청소 미스테리", "호두의 일정", "로또?", "3", "4", "5", "6", "7", "8" };
        public int[] pancake_DialogeKeywordsOpen = { 0, 0, 0, 0, 0, 0, 0, 0 };

        public string[] cakeDialogeKeywords = { "컵케익과 딸기잼 사이", "냉동창고의 상태", "1", "2", "3", "4", "5", "6", "7", "8" };
        public int[] cake_DialogeKeywordsOpen = { 0, 0, 0, 0, 0, 0, 0, 0 };

        public string[] croisDialogeKeywords = { "크로아상의 의심", "day1크로아상 알리바이", "오븐 방문", "3", "4", "5", "6", "7", "8" };
        public int[] crois_DialogeKeywordsOpen = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public string[] macaDialogeKeywords = { "딸기잼과 젤리의 관계", "오븐그램에 대한 집착", "스토커", "3", "4", "5", "6", "7", "8" };
        public int[] maca_DialogeKeywordsOpen = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public string[] jellyDialogeKeywords = { "day1 알리바이", "그림도구", "젤리들의 싸움", "젤리젤리의 행방", "4", "5", "6", "7", "8" };
        public int[] jelly_DialogeKeywordsOpen = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public string[] jellyjellyDialogeKeywords = { "천상화가","천연재료","할 일" };
        public int[] jellyjelly_DialogeKeywordsOpen = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public string[] jamDialogeKeywords = { "딸기잼과 슈가게이즈", "딸기잼과 언쟁", "호텔 지원금의 행방", "귀찮은 팬케이크", "4", "5", "6", "7", "8" };
        public int[] jam_DialogeKeywordsOpen = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public string[] hoduDialogeKeywords = { "수상한 제안", "큰 건", "2", "3", "4", "5", "6", "7", "8" };
        public int[] hodu_DialogeKeywordsOpen = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public string[] twistDialogeKeywords = { "일정", "냉동창고의 문", "2", "3", "4", "5", "6", "7", "8" };
        public int[] twist_DialogeKeywordsOpen = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public string[] chocoDialogeKeywords = { "day1 알리바이", "호두와의 사이 ", "신문","3층엔 무엇이?", "냉동창고의 열쇠", "목격", "5", "6", "7", "8" };
        public int[] choco_DialogeKeywordsOpen = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public string[] donutDialogeKeywords = { "도넛과 딸기잼의 사이", "밤에 나눈 대화", "마카롱 의심", "3", "4", "5", "6", "7", "8"};
        public int[] donut_DialogeKeywordsOpen = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public void checkDialogue(string characterName)
        {
            //대화 했는지 캐릭터 이름을 받아서 확인 
            // day N , 캐릭터, N번째 확인이 아니지. 이름을 바꿔야할수도 있겠다. 이건 ㅇ회의 후 하기로  
            
        }

    }

}