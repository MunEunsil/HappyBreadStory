using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace HappyBread.GamePlay
{
    /// <summary>
    /// 게임이 진행되면서 변동되는 정보를 저장하고 관리하는 매니저 클래스
    /// </summary>
    /// 
    public class DataManager : MonoBehaviour
    {
        private static DataManager _instance;

        public static DataManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = GameObject.Find("DataManager").GetComponent<DataManager>();
                }
                return _instance;
            }
        }

        private bool isPause = false;

        public bool dialogeEvidence = false; 

        public string PlayerName { get; set; }

        public List<Evidence> evidences = new List<Evidence>();
        public int date = 1;
        public int floor = 1;


        //수정 오프닝 세팅을 위해 추가 (은실 2022.05.07)
        public bool isPlaying = true; //true :  start or load 를 안누른 상태  false : start or load를 누른상태 


        //비네트 컬러 
        public ColorParameter vignetterColor;
        //hp 감소 이펙트 
        public bool WEff = true; //false : 효과X true : 효과 ㅇ

        //지하1층 들어갔는지 체크하기 위함 
        public bool inOven = false;
        public bool inPriz = false;
        //지하1층 타이머 
        public bool stopTimer = true; //true : 멈춤 , false : 진행 

        //열쇠 열림 유무 
        public bool strawRoomKey = false;
        public bool masterKey = false;
        public bool Day3_freezerKey = false; //f : 막힘 / t : 열림

        public int newsnum = 1;

        public int select = -1;
        public bool stair = false;
        
        public string middleEndingName;

        public bool stopVoice = false; //true : 캐릭터 보이스 X , false : 캐릭터 포이스 O 

        public float playerPosition; //플레이어 위치 (저장 불러오기 위함)

        //엔딩 저장할 배열
        public bool[] ending_ = { false, false, false, false, false, false, false, false, false, false, false };

        //해피엔딩 저장할 배열 
        public bool[] ending_happyEnding = { false, false }; //0번이 happy엔딩 , 1번에 bad엔딩 

        //day2 대화 흐름을 제어할 변수
        public bool day2Crois_lie = false; //true : 크로아상 2번째 대화의 2번째 선택지 열림, false : 안열림 


        //day마다 대화 한 횟수를 저장할 변수
        public int cake, choco, crois, donut, hodu, jam, jelly, jellyjelly, maca, pancake, straw, twist = 0;

        //딸기 방 열기 위한 조건 
        public bool QuestionStrawRoom = false;
        // false : 닫힘 , true : 열림 
        public bool strawRoomOpen = false;

        //day이벤트에서 사용할 nextCommand 
        public KeyCode Day_nextCommand;

        //중간엔딩을 만들기 위한 변수 
        public int chocoFondue = 0; //3회 이상 조사하면 퐁듀엔딩
        public int ovenEnding = 0; //3회 이상 조사하면 오븐엔딩 
        public int freezerEnding =0;

        //추리하기 - 사건 선택
        public bool Choice_StrawCase = false;
        public bool Choice_HoduCase = false;
        public bool Choice_JellyjellyCase = false;

        //추리하기 시작하면 피 주는거 멈추게 하기 위함 
        public bool callStart = false;

        //추리하기 - 추리 
        // false : 자살 , true : 타살
        public bool isSuicide = false;
        public bool isStrawSuicide = false; 
        public bool isHoduSuicide = false;
        public bool isJellyjellySuicide = false;

        //추리하기 - 결과 
        // false : 실패    true : 성공  
        public bool isStrawCaseFail = false;
        public bool isHoduCaseFail = false;
        public bool isJellyjellyFail = false;

        //해피엔딩 텍스느 나오는거
        public bool EndingTextDone = false;
        //각 사건에서 사용할 증거 변수

        //딸기사건 사고/타살
        public string[] straw_CaseEvidence1 = new string[] { "evidence_Handrail", "evidence_cosmetic", "evidence_gamble", "evidence_Straw_Lid", "evidence_moneyInJam", "evidence_boosts" };
        //딸기사건 범인지목
        public string[] straw_CaseEvidence2 = new string[] { "evidence_sugar", "evidence_jamMessage", "evidence_bag", "evidence_hat", "evidence_jellyjelly_pic", "evidence_jelly_news" };

        //호두사건 사고/타살
        public string[] hodu_CaseEvidence1 = new string[] { "evidence_f3333333", "evidence_freez_key", "evidence_freezer", "evidence_edvCosmetic", "evidence_donutHodu", "evidence_staff_twist" };
        //호두사건 범인지목 
        public string[] hodu_CaseEvidence2 = new string[] { "evidence_NonePicture", "evidence_newspapaer", "evidence_MabyMacaPictrue", "evidence_medi", "evidence_ribontxt", "evidence_macaPictrue" };

        //젤리젤리사건 사고/타살
        public string[] jellyjelly_CaseEvidence1 = new string[] { "evidence_oven_ma", "evidence_message_maca", "evidence_choco_sighting", "evidence_freez_key", "evidence_oven", "evidence_jellyjellyDiary" };
        //젤리젤리 범인지목
        public string[] jellyjelly_CaseEvidence2 = new string[] { "evidence_jelly_news", "evidence_jellyjellyDiary", "evidence_jelly_pic", "evidence_jelly_cos", "evidence_MessageInJam", "크로아상거짓말" };


        //각 사건에서 사용할 증거 텍스트

        //딸기사건 타살
        public string[] straw_CaseText1 = new string[] { "딸기잼보다 훨씬 높다.","딸기잼의 돈을 노렸다." };
        public string[] straw_CaseText2 = new string[] {"누군가에게 받은것이다.","돌려서 여는 형식이다."};
        //딸기사건 사고
        public string[] Suicede_straw_CaseText2 = new string[] { "실수로 떨어졌다.", "미끄러졌다." };

        //딸기사건 범인지목
        public string[] straw_CaseText11 = new string[] { "투자 실패로, 많은 돈이 필요하다.", "같은 학교 출신이라는 소문이 있다."};
        public string[] straw_CaseText22 = new string[] { "빌미로 돈을 달라 협박했다.", "결혼을 취소해달라 했다."};

        //호두사건 타살
        public string[] hodu_CaseText1 = new string[] { "오랫동안 냉동 창고 문이 열려있었다.", "관리가 소홀했다." };
        public string[] hodu_CaseText2 = new string[] { "원래는 1층에 있으면 안된다.", "다른 누군가 있었다." };

        //호두사건 사고 
        public string[] Suicede_hodu_CaseText2 = new string[] { "그림을 훔치려다 갇혔다.", "키를 두고왔다." };

        //호두사건 범인지목
        public string[] hodu_CaseText11 = new string[] { "협박 편지를 보냈다.", "어디선가 봤던 물건이다." };
        public string[] hodu_CaseText22 = new string[] { "훔쳤다.", "싸인이 없어 사용할 수 없다." };

        //젤리젤리사건 타살
        public string[] jellyjelly_CaseText1 = new string[] { "잠금 장치 없는 밀어서 여는 문이다.", "너무 온도가 높아 녹아 내렸다." };
        public string[] jellyjelly_CaseText2 = new string[] { "계획적인 연쇄 살인이다.", "소라빵이 담당 직원이었다" };

        //젤리젤리 사건 사고 
        public string[] Suicede_jellyjelly_CaseText2 = new string[] { "갇혀버렸다.", "잠들어버렸다." };

        //젤리젤리사건 범인지목
        public string[] jellyjelly_CaseText11 = new string[] { "진실을 밝히려 했다.  ", "불안정한 심리였다." };
        public string[] jellyjelly_CaseText22 = new string[] { "재료 차별을 반대한다.", "천연 재료인척 한다." };


        //엔딩 결과를 위함 
        public bool happyEnding = false; //true 면 해피엔딩

        //사건수첩 대화 키워드 오픈을 위한 변수 
        public bool[] straw_DialogeKeywordsOpen = { false, false, false, false, false, false, false, false, false, false, false }; // 딸기잼


        public bool[] pancake_DialogeKeywordsOpen = { false, false, false, false, false, false, false, false }; //팬케이크

        public bool[] cake_DialogeKeywordsOpen = { false, false, false, false, false, false, false, false };// 컵케이크

        public bool[] crois_DialogeKeywordsOpen = { false, false, false, false, false, false, false, false, false, false }; //크로아상

        public bool[] maca_DialogeKeywordsOpen = { false, false, false, false, false, false, false, false, false, false }; //마카롱

        public bool[] jelly_DialogeKeywordsOpen = { false, false, false, false, false, false, false, false, false, false }; //젤리

        public bool[] jellyjelly_DialogeKeywordsOpen = { false, false, false, false, false,false,false,false,false,false }; //젤리젤리

        public bool[] jam_DialogeKeywordsOpen = { false, false, false, false, false, false, false, false, false, false }; //땅콩잼

        public bool[] hodu_DialogeKeywordsOpen = { false, false, false, false, false, false, false, false, false, false }; //호두

        public bool[] twist_DialogeKeywordsOpen = { false, false, false, false, false, false, false, false, false, false }; //꽈배기

        public bool[] choco_DialogeKeywordsOpen = { false, false, false, false, false, false, false, false, false, false }; //초코소라빵

        public bool[] donut_DialogeKeywordsOpen = { false, false, false, false, false, false, false, false, false, false }; //도넛




        public KeyCode Call_NextCommand;
        public bool IsPause
        {
            get
            {
                return isPause;
            }
            set
            {
                isPause = value;
            }
        }

        private void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

    }
}
