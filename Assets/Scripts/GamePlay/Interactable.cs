using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    /// <summary>
    /// 상호작용 가능한 물체의 경우 상속받아야할 클래스.
    /// </summary>
    public abstract class Interactable : MonoBehaviour
    {
        // 상호 작용이 가능한 물체는 언제나 증거가 될 수 있다.
        // 때문에 이 곳에는 그에 대한 상세 내용을 작성해야한다.
        public Evidence Evidence { get; protected set; } 

        public abstract void Interact();

        protected abstract void InitEvidence();

        private void Awake()
        {
            InitEvidence();
        }
    }
}
