using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay.GameState
{
    public class ReasoningState : IState
    {
        public void Change()
        {
            GameModel.Instance.InputManager.SetState(InputManager.State.ReanonsingControl);
        }
    }
}