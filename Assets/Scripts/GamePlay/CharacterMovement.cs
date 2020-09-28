using HappyBread.GamePlay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class CharacterMovement : MovingObject
    {
        private int waypointIndex = 0; //이동포인트 인덱스

        private readonly float minDistance = 0.5f;
        private List<Vector3> currentWaypoints;
        public Vector3 destination;
        public WayPoints wayPoints;
        public int startWayPoint;

        private State state;

        public void SetIdleState()
        {
            this.state = State.Idle;
        }

        public void SetWalkingState()
        {
            this.state = State.Walking;
        }

        public void ChangeWayPoints(int index)
        {
            currentWaypoints = wayPoints.GetWayPoints(index);
            waypointIndex = 0;
            destination = currentWaypoints[waypointIndex];
        }

        private void Start()
        {
            state = State.Walking;
            // 본인에게 맞는 waypoints를 불러온다.
            // 받아오는 형식만 변경된다면 waypoints 가 다르게 구현되어도 될듯
            ChangeWayPoints(startWayPoint);
        }

        private void Update()
        {
            if (DataManager.Instance.IsPause)
            {
                Stop();
            }
            else
            {
                switch (state)
                {
                    case State.Idle:
                        Stop();
                        break;
                    case State.Walking:
                        BeforeMove();
                        break;
                    default:
                        break;
                }
            }
        }

        private void BeforeMove()
        {
            Vector2 direction = destination - transform.position;
            Move(direction);
        }

        protected override void AfterMove()
        {
            SetDestination();
        }

        private void SetDestination()
        {
            if (Vector3.Distance(destination, transform.position) <= minDistance)
            {
                waypointIndex = ( waypointIndex + 1 ) % currentWaypoints.Count;
                destination = currentWaypoints[waypointIndex];
            }
        }
    }
}