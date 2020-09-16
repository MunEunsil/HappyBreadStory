using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class QuestionBoxEvent : Event
    {
        protected override void BeginDetail()
        {
            GameModel.Instance.questionBox.gameObject.SetActive(true); // UI 관련
            GameModel.Instance.questionBox.questionBoxEvent = this;
            GameModel.Instance.inputManager.ChangeState(InputManager.State.QuestionManagerControl); // Input 관련
            List<string> test = new List<string>();
            test.Add("1. 안녕 나는 재상");
            test.Add("2. 안녕 나는 재중");
            test.Add("3. 안녕 나는 재하");
            GameModel.Instance.questionBox.CreateSelector(test);
        }

        protected override void EndDetail()
        {
            
        }
    }
}
