using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class EventManager : MonoBehaviour
    {
        private Queue<Event> waitingQueue; // 대기 중인 이벤트가 등록됩니다.
        private List<Event> runningStack; // 실행 중인 이벤트가 등록됩니다.

        private enum State
        {
            Idle,       // 큐와 스택이 모두 비어있을 경우
            Waiting,    // 스택이 비어있는 경우, 즉 실행되고 있는 이벤트가 없는 경우
            Running     // 스택이 비어있지 않은 경우, 즉 실행되고 있는 이벤트가 있는 경우
        }

        private State state;
        private void Update()
        {
            switch(state)
            {
                case State.Idle:
                    IdleState();
                    break;
                case State.Waiting:
                    WaitingState();
                    break;
                case State.Running:
                    RunningState();
                    break;
            }
        }

        private void RunningState()
        {
            // running stack이 비어있다면, waiting 상태로 변경한다.
            if (runningStack.Count == 0)
            {
                state = State.Waiting;
                return;
            }
            // running stack의 맨 위에 이벤트가 끝났다면, waiting 상태로 변경한다.
            else if (runningStack[runningStack.Count - 1].eventState == Event.EventState.Terminated)
            {
                runningStack.RemoveAt(runningStack.Count - 1);
                state = State.Waiting;
            }
        }

        private void WaitingState()
        {
            // 둘 다 비어있다면 Idle 상태로 변경한다.
            if (waitingQueue.Count == 0 && runningStack.Count == 0)
            {
                state = State.Idle;
                return;
            }
            // running stack이 비어있다면 waitingQueue에서 이벤트를 실행시킨다.
            else if (runningStack.Count == 0)
            {
                state = State.Running;
                Event _event = waitingQueue.Dequeue();
                runningStack.Add(_event);
                _event.Begin();
            }
        }

        private void IdleState()
        {
            if (waitingQueue.Count != 0 || runningStack.Count != 0)
            {
                state = State.Waiting;
            }
        }


        /// <summary>
        /// Blocking Event를 추가합니다. 실행중인 이벤트가 존재한다면, 이벤트는 대기 큐에 쌓입니다.
        /// </summary>
        public void AddBlockingEvent(Event _event)
        {
            if (state == State.Running)
            {
                waitingQueue.Enqueue(_event);
            }
            else
            {
                state = State.Running;
                runningStack.Add(_event);
                _event.Begin();
            }
        }

        private void Awake()
        {
            runningStack = new List<Event>();
            waitingQueue = new Queue<Event>();
        }
    }
}
