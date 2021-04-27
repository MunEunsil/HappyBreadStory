using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HappyBread.GamePlay.GameState;

namespace HappyBread.GamePlay
{
    public class CallBtn : MonoBehaviour
    {
        [SerializeField]
        private GameObject reasoningManager;

        public void Appear()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
        public void ClickCall()
        {
            reasoningManager.SetActive(true);
            //state 변경 
            GameModel.Instance.StateManager.ChangeState(new ReasoningState());

        }
    }

}

