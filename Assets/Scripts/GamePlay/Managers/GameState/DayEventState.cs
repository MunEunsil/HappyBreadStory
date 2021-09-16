﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay.GameState
{
    public class DayEventState : IState
    {
        public void Change()
        {
            GameModel.Instance.InputManager.SetState(InputManager.State.DayEventControl);
        }
    }
}