using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public abstract class Event
    {
        public Event ParentEvent { get; set; }

        public enum EventState
        {
            Waiting, // 실행 전 기다리는 상태
            Running, // 실행하고 있는 상태
            Stopped, // 잠시 대기한 상태
            Terminated // 실행이 종료된 상태
        }

        public EventState eventState = EventState.Waiting;

        public void Begin()
        {
            eventState = EventState.Running;
            BeginDetail();
        }

        protected abstract void BeginDetail();

        public void End()
        {
            eventState = EventState.Terminated;
            EndDetail();

            if (ParentEvent != null)
            {
                ParentEvent.End();
            }
        }

        protected abstract void EndDetail();

        public void Pause()
        {
            eventState = Event.EventState.Stopped;
        }
        public void Resume()
        {
            eventState = Event.EventState.Running;
        }
    }
}