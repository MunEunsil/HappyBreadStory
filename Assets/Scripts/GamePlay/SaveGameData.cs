using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace HappyBread.GamePlay
{
    [Serializable] 

    public class SaveGameData
    {
        //이름
        public string PlayerNmae;

        //날짜 
        public int date;//= DataManager.Instance.date; 이건 저기 dataController에서 
        //증거
        public List<Evidence> evidences = new List<Evidence>();
        //Day3_freezerKey = false;
        public bool day3FreezerKey;


        //대화 열림 유무에 대한 정보 

        public List<bool> straw_keyword = new List<bool>(); // 딸기잼 대화 키워드 

        public List<bool> pancake_keyword = new List<bool>(); 

        public List<bool> cake_keyword = new List<bool>();

        public List<bool> crois_keyword = new List<bool>();

        public List<bool> maca_keyword = new List<bool>();

        public List<bool> jelly_keyword = new List<bool>();

        public List<bool> jellyjelly_keyword = new List<bool>();

        public List<bool> jam_keyword = new List<bool>();

        public List<bool> hodu_keyword = new List<bool>();

        public List<bool> twist_keyword = new List<bool>();

        public List<bool> choco_keyword = new List<bool>();

        public List<bool> donut_keyword = new List<bool>();

        public List<string> evidence_name = new List<string>();

        public List<string> evidence_Sprite = new List<string>();

    }

}
