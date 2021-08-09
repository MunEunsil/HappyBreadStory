using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


        public int newsnum = 1;

        public int select = -1;
        public bool stair = false;
        
        public string middleEndingName;

        public float playerPosition; //플레이어 위치 (저장 불러오기 위함)

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

        //각 사건에서 사용할 증거 변수
        
        //딸기사건 사고/타살
        public string[] straw_CaseEvidence1 = new string[] {"난간의높이","딸기잼화장품","도박_초대장","딸기뚜껑","1억수표3장","빨간부츠" };
        //딸기사건 범인지목
        public string[] straw_CaseEvidence2 = new string[] { "슈가게이지", "땅콩잼의편지", "명품가방", "명품모자", "젤리젤리사진", "딸기잼의소문과동기" };

        //호두사건 사고/타살
        public string[] hodu_CaseEvidence1 = new string[] { "도박코인", "냉동창고_열쇠", "녹은아이스크림눈사람", "화장품광고지", "도넛과호두관계", "민중을이끄는꽈배기" };
        //호두사건 범인지목 
        public string[] hodu_CaseEvidence2 = new string[] { "싸인없는그림", "오려진신문기사", "막가롱과거사진", "막가롱의약", "리본", "막가롱액자사진" };

        //젤리젤리사건 사고/타살
        public string[] jellyjelly_CaseEvidence1 = new string[] { "오븐방마시멜로", "막가롱의협박편지", "소라빵의목격", "냉동창고_열쇠", "젤리젤리의흔적", "젤리젤리다이어리" };
        //젤리젤리 범인지목
        public string[] jellyjelly_CaseEvidence2 = new string[] { "젤리가스크랩한기사", "젤리젤리다이어리", "젤리의미완성그림", "젤리의화장품", "시럽묻은편지", "크로아상거짓말" };


        //각 사건에서 사용할 증거 텍스트

        //딸기사건 사고/타살
        public string[] straw_CaseText1 = new string[] { "딸기잼보다 훨씬 높다.","딸기잼의 돈을 노렸다." };
        public string[] straw_CaseText2 = new string[] {"누군가에게 받은것이다.","돌려서 여는 형식이다."};
        //딸기사건 범인지목
        public string[] straw_CaseText11 = new string[] { "투자 실패로, 많은 돈이 필요하다.", "같은 학교 출신이라는 소문이 있다."};
        public string[] straw_CaseText22 = new string[] { "빌미로 돈을 달라 협박했다.", "결혼을 취소해달라 했다."};

        //호두사건 사고/타살
        public string[] hodu_CaseText1 = new string[] { "오랫동안 냉동 창고 문이 열려있었다.", "관리가 소홀했다." };
        public string[] hodu_CaseText2 = new string[] { "원래는 1층에 있으면 안된다.", "다른 누군가 있었다." };
        //호두사건 범인지목
        public string[] hodu_CaseText11 = new string[] { "협박 편지를 보냈다.", "어디선가 봤던 물건이다." };
        public string[] hodu_CaseText22 = new string[] { "훔쳤다.", "싸인이 없어 사용할 수 없다." };

        //젤리젤리사건 사고/타살
        public string[] jellyjelly_CaseText1 = new string[] { "잠금 장치 없는 밀어서 여는 문이다.", "너무 온도가 높아 녹아 내렸다." };
        public string[] jellyjelly_CaseText2 = new string[] { "계획적인 연쇄 살인이다.", "소라빵이 담당 직원이었다" };
        //젤리젤리사건 범인지목
        public string[] jellyjelly_CaseText11 = new string[] { "진실을 밝히려 했다.  ", "불안정한 심리였다." };
        public string[] jellyjelly_CaseText22 = new string[] { "재료 차별을 반대한다.", "천연 재료인척 한다." };


        //엔딩 결과를 위함 
        public bool happyEnding = false; //true 면 해피엔딩

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
