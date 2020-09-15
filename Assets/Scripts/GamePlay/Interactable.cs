using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public abstract class Interactable : MonoBehaviour
    {
        private Evidence evidence;

        public abstract void Interact();
    }
}
