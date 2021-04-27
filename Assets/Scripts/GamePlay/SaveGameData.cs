using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace HappyBread.GamePlay
{
    [Serializable] //직렬화

    public class SaveGameData
    {
        //플레이어 위치 
        public float playerPosition = DataManager.Instance.playerPosition;
        //날짜 
        public int date = DataManager.Instance.date;
        //증거수집현황
        public List<Evidence> evidences = DataManager.Instance.evidences;
        //대화 열림 유무에 대한 정보 
        //아직 대화 시스템 안바꿨으니까 ㄱㄷ

    }

}
