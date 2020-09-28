using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay.GameState
{
    public class PauseState : IState
    {
        public void Change()
        {
            GameModel.Instance.InputManager.SetState(InputManager.State.Pause);
            GameModel.Instance.UIManager.BasicUIHide();
            DataManager.Instance.IsPause = true;
        }
    }
}