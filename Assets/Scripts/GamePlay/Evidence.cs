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
        public string Name { get; set; }
        public string Content { get; set; }
        public Sprite Sprite { get; set; }
        public Action Action { get; set; }

    }
}
