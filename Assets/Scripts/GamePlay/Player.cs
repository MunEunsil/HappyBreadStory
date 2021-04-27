using HappyBread.Core;
using HappyBread.ETC;
using HappyBread.GamePlay.GameState;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

namespace HappyBread.GamePlay
{
    /// <summary>
    /// 플레이어를 제어 할 수 있는 클래스.
    /// </summary>
    ///


    public class Player : MovingObject
    {

        [HideInInspector]
        public Vector3 NextMoveCommand; // 다음 움직임 명령
        [HideInInspector]
        public KeyCode NextFunctionCommand;
        public LayerMask interactableLayer;
        public LayerMask evidenceLayer;
        public float hitDistance = 0.5f;
        public float useHpAmount = 0.01f;

        private State state;
        private RaycastHit2D hit;

        private void Start()
        {
            state = State.Idle;
        }

        private void Update()
        {
            // 움직임 구현부 ( 화살표 키 )
            switch (state)
            {
                case State.Idle:
                    IdleState();
                    break;
                case State.Walking:
                    WalkingState();
                    break;
                default:
                    break;
            }

            // 그 외 단축키 구현부 ( 상호작용 키 )
            if (NextFunctionCommand != KeyCode.None)
            {
                switch (NextFunctionCommand)
                {
                    case GlobalGameData.keyCodeInteract:
                        AttemptInteract();
                        break;
                    case GlobalGameData.keyCodeCaseDiary:
                        Debug.Log("a누름");
                        AttemptOpenCaseDiary();
                        break;
                    case GlobalGameData.keyCodeCall: 
                        Debug.Log("c누름");
                        AttemptOpenCall();
                        break;
                    default:
                        break;
                }
            }
        }

        private void AttemptOpenCaseDiary()
        {
            GameModel.Instance.StateManager.ChangeState(new CaseDiaryState());
            GameModel.Instance.CaseDiary.gameObject.SetActive(true);
            NextFunctionCommand = KeyCode.None;
        }
        private void AttemptOpenCall()
        {
            GameModel.Instance.StateManager.ChangeState(new CallState());
            GameModel.Instance.Call.gameObject.SetActive(true);
            NextFunctionCommand = KeyCode.None;
        }

        private void AttemptInteract()  
        {
            Vector2 start = transform.position;
            Vector2 end = (Vector2)transform.position + objectDirection * hitDistance;
            hit = Physics2D.Linecast(start, end, interactableLayer);
            if (hit.transform != null)
            {
                Interact(hit);
            }
            NextFunctionCommand = KeyCode.None;
        }

        private void Interact(RaycastHit2D hit)
        {
            Interactable interactable = hit.transform.GetComponent<Interactable>();
            if(interactable != null)
            {
                interactable.Interact();
            }
            else
            {
                Debug.Log("Can't Find Interactable");
            }
        }

        private void IdleState()
        {
            if (NextMoveCommand != Vector3.zero) // 움직이라는 명령을 받음
            {
                state = State.Walking;
            }
            else
            {
                if (rigidBody2D.velocity != Vector2.zero)
                {
                    Stop();
                }
            }
        }

        private void WalkingState()
        {
            if (NextMoveCommand != Vector3.zero) // 움직이라는 명령 받음
            {
                Move(NextMoveCommand);
            }
            else // 움직임 상태 해제
            {
                state = State.Idle;
            }
        }
        private void SaveGame()
        {
            SaveLoad.instance.SaveGameData();
        }

        protected override void AfterMove()
        {
            NextMoveCommand = Vector3.zero;
            GameModel.Instance.Hp.Add(-useHpAmount); // Hp 변동
        }
    }
}