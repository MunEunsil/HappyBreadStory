using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class QuestionBoxEvent : Event
    {
        private List<string> questions;

        public QuestionBoxEvent(List<string> questions)
        {
            this.questions = questions;
        }

        protected override void BeginDetail()
        {
            GameModel.Instance.questionBox.gameObject.SetActive(true); // UI 관련
            GameModel.Instance.questionBox.ConnectedEvent = this;
            GameModel.Instance.questionBox.CreateSelector(questions);
        }

        protected override void EndDetail()
        {
            questions = new List<string>();
        }
    }
}
