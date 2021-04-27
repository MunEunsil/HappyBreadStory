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

        public string middleEndingName;

        public float playerPosition; //플레이어 위치 (저장 불러오기 위함)

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
