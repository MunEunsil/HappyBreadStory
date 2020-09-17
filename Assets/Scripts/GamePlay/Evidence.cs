using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HappyBread.GamePlay
{
    /// <summary>
    /// 증거에 대한 자료를 저장하는 클래스.
    /// </summary>
    public class Evidence
    {
        public string Name { get; set; } // 증거의 이름
        public string Content { get; set; } // 증거의 내용
        public Sprite Sprite { get; set; } // 증거의 이미지
        public Action Action { get; set; } // 증거를 선택하면 발생하는 액션
    }
}
