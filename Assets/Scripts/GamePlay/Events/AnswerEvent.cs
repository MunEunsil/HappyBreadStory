using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

namespace HappyBread.GamePlay
{
    public class AnswerEvent : Event
    {
        List<Event> events;

        public AnswerEvent(List<Event> events)
        {
            this.events = events;
        }

        protected override void BeginDetail()
        {
            // TODO : 현재는 선택된 답변을 제일 뒤에 밀어 넣는다. 그렇게 하지 않기 위한 개선이 필요하다.
            int index = GameModel.Instance.questionBox.AnswerIndex;

            events[index].ParentEvent = this;
            events[index].Begin(); // 등록된 이벤트를 실행한다.
        }

        protected override void EndDetail()
        {
        }
    }
}