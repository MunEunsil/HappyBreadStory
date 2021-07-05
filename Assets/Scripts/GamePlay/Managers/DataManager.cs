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

        public string PlayerName { get; set; }

        public List<Evidence> evidences = new List<Evidence>();
        public int date = 1;
        public int floor = 1;

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
        public string[] strawCaseEvidence1 = new string[] {"경매그림","난간","냉동창고_열쇠","딸기뚜껑","리본","신문기사" };
        //딸기사건 범인지목
        public string[] strawCaseEvidence2 = new string[] { "젤리젤리사진", "난간", "쪽지", "신문기사", "리본", "젤리화장품" };

        //호두사건 사고/타살
        public string[] hoduCaseEvidence1 = new string[] { "경매그림", "난간", "냉동창고_열쇠", "딸기뚜껑", "리본", "젤리화장품" };
        //호두사건 범인지목 
        public string[] hoduCaseEvidence2 = new string[] { "경매그림", "난간", "냉동창고_열쇠", "딸기뚜껑", "리본", "쪽지" };

        //젤리젤리사건 사고/타살
        public string[] jellyjellyCaseEvidence1 = new string[] { "경매그림", "난간", "냉동창고_열쇠", "딸기뚜껑", "리본", "신문기사" };
        //젤리젤리 범인지목
        public string[] jellyjellyCaseEvidence2 = new string[] { "경매그림", "난간", "냉동창고_열쇠", "딸기뚜껑", "리본", "신문기사" };


        //각 사건에서 사용할 증거 텍스트

        //딸기사건 사고/타살
        public string[] strawCaseText1 = new string[] { "선택지1","선택지2","선택지3"  };
        public string[] strawCaseText2 = new string[] {"선택지1","선택지2","선택지3" };
        //딸기사건 범인지목
        public string[] strawCaseText11 = new string[] { "선택지1", "선택지2", "선택지3" };
        public string[] strawCaseText22 = new string[] { "선택지1", "선택지2", "선택지3" };

        //호두사건 사고/타살
        public string[] hoduCaseText1 = new string[] { "선택지1", "선택지2", "선택지3" };
        public string[] hoduCaseText2 = new string[] { "선택지1", "선택지2", "선택지3" };
        //호두사건 범인지목
        public string[] hoduCaseText11 = new string[] { "선택지1", "선택지2", "선택지3" };
        public string[] hoduCaseText22 = new string[] { "선택지1", "선택지2", "선택지3" };

        //젤리젤리사건 사고/타살
        public string[] jellyjellyCaseText1 = new string[] { "선택지1", "선택지2", "선택지3" };
        public string[] jellyjellyCaseText2 = new string[] { "선택지1", "선택지2", "선택지3" };
        //젤리젤리사건 범인지목
        public string[] jellyjellyCaseText11 = new string[] { "선택지1", "선택지2", "선택지3" };
        public string[] jellyjellyCaseText22 = new string[] { "선택지1", "선택지2", "선택지3" };


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
