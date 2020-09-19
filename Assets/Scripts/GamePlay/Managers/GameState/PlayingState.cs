using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay.GameState
{
    public class PlayingState : IState
    {
        public void Change()
        {
            GameModel.Instance.InputManager.SetState(InputManager.State.PlayerControl);
            GameModel.Instance.UIManager.HpAppear();
        }
    }
}