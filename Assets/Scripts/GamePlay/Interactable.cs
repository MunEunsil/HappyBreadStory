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
        protected Evidence evidence;

        public abstract void Interact();
    }
}
