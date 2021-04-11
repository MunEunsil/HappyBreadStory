using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay.GameState
{
    public class RoomInvestigateState : IState
    {
        public void Change()
        {
            GameModel.Instance.InputManager.SetState(InputManager.State.RoomInvestigateControl); 
        }
    }
}
