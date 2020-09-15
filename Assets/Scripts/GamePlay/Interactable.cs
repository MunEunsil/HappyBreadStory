using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public abstract class Interactable : MonoBehaviour
    {
        protected Evidence evidence;

        public abstract void Interact();
    }
}
