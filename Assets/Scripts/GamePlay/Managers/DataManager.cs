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
