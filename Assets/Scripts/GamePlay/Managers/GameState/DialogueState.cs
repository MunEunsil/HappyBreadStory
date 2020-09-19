using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay.GameState
{
    public class DialogueState : IState
    {
        public void Change()
        {
            GameModel.Instance.InputManager.SetState(InputManager.State.DialogueControl);
            GameModel.Instance.UIManager.BasicUIHide();
            GameModel.Instance.Dialogue.gameObject.SetActive(true);
        }
    }
}