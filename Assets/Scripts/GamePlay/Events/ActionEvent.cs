using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class ActionEvent : Event
    {
        Action action = null;

        public ActionEvent(Action action)
        {
            this.action = action;
        }

        protected override void BeginDetail()
        {
            action();
            End();
        }

        protected override void EndDetail()
        {
            
        }
    }
}
