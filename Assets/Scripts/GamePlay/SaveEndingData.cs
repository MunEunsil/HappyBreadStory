using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace HappyBread.GamePlay
{
    [Serializable]

    public class SaveEndingData
    {
        //엔딩 데이터
        public List<bool> Ending = new List<bool>(); //엔딩 0번~n번 엔딩까지 정리해두기 
        public List<bool> HappyEnding = new List<bool>(); //해피엔딩, 배드엔딩 

        /*
         * 0번 ___ 솜사탕 안개 추락
         * 1번 ___ 곰팡이 빵 
         * 2번 ___ 초콜릿 퐁듀 
         * 3번 ___ 식빵을 얼려서 보관 
         * 4번 ___ 토스트가 되어 버렸어  
         * 또 있나?
         */

    }
}

