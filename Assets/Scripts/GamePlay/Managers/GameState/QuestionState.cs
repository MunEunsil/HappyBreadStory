using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay.GameState
{
    public class QuestionState : IState
    {
        public void Change()
        {
            GameModel.Instance.InputManager.SetState(InputManager.State.QuestionBoxControl);
            GameModel.Instance.UIManager.HpHide();
            GameModel.Instance.QuestionBox.gameObject.SetActive(true); // UI 관련
        }
    }
}

