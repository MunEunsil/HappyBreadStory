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
        public string[] strawDialogeKeywords = { "뉴스에 나온 그", "수준 낮아서", "", "", "", "", "", "", "" };

       // public string[] strawDialogeKeywords = { "뉴스에 나온 그", "수준 낮아서", "", "", "", "", "" };


        public string[] pancakeDialogeKeywords = { "헬기", "친구를 잃었어", "호두는 찜질방", "누구 말을 믿어?", "", "", "", "", "" };
        

        public string[] cakeDialogeKeywords = { "세계적으로 인정", "꼴 좋지!", "프로페셔널", "아이스크림 눈사람", "명성에 금", "", "", "", "", "" };
        

        public string[] croisDialogeKeywords = { "20년동안 사건사고", "거짓말", "빵수가 맞아야", "3층으로 오라고~", "밖으로 미는 형식", "", "", "", "" };
       

        public string[] macaDialogeKeywords = { "특종이다!", "나도 친해지고 싶당!", "스토커나 협박범", "어이없는 실수", "", "", "", "", "" };
        

        public string[] jellyDialogeKeywords = { "쌍둥이 동생", "동생과 방에", "스케치 도구", "차별에 관한", "화해", "", "", "", "" };
        

        public string[] jellyjellyDialogeKeywords = { "우린 함께야..","그림은 마음을 치유...","천연재료" };

        public string[] jamDialogeKeywords = { "약혼자", "슈가 게이지", "청소부가 쳐다보는게 좀..", "후원금을 지원", "4", "5", "6", "7", "8" };
        

        public string[] hoduDialogeKeywords = { "재밌는 거", "큰건 하나 합니다!", "2", "3", "4", "5", "6", "7", "8" };

        public string[] twistDialogeKeywords = { "3대째 5성", "솜사탕 안개 ", "행사 일정", "호텔의 VIP", "마스터 키", "들인 돈", "6", "7", "8" };
        

        public string[] chocoDialogeKeywords = { "지금 밖에 나가면…", " 사장님이나 호두나 다 돈에 눈이… ", "호두씨랑 사이", " 호두는 벌 받은거에요…", " 승진", "목격", "5", "6", "7", "8" };
        

        public string[] donutDialogeKeywords = { "정말 사고죠?", "호두와는 연인사이", "가까운 사이", "오븐은 소라빵 담당", "", "", "", "", ""};
        

        public void checkDialogue(string characterName)
        {
            //대화 했는지 캐릭터 이름을 받아서 확인 
            // day N , 캐릭터, N번째 확인이 아니지. 이름을 바꿔야할수도 있겠다. 이건 ㅇ회의 후 하기로  
            
        }

    }

}