using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

namespace HappyBread.GamePlay
{
    /// <summary>
    /// 질문에 대한 답변을 한 뒤에 해당 답에 대한 이벤트를 발생시키기 위해 만든 이벤트
    /// 실수할 가능성이 있기 때문에 개수를 잘 맞춰서 작성해야한다.
    /// </summary>
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