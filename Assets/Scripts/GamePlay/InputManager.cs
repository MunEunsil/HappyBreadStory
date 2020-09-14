using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HappyBread.GamePlay;
using System;
using HappyBread.Core;

namespace HappyBread.GamePlay
{
    public class InputManager : MonoBehaviour
    {
        public PlayerControl playerControl;
        public Dialogue dialogue;
        public CaseDiary caseDiary;

        private List<State> stack; // 이전 상태를 저장합니다.


        public enum State
        {
            PlayerControl,
            DialogControl,
            CaseDiaryControl,
            Pause
        }

        private State state;

        // 스택에 현재 상태를 저장하고 인자로 받은 상태로 변경합니다.
        public void ChangeState(State state)
        {
            stack.Add(this.state);
            this.state = state;
        }

        // 이전 상태로 되돌립니다.
        public void UndoState()
        {
            if (stack.Count > 0)
            {
                int index = stack.Count - 1;
                this.state = stack[index];
                stack.RemoveAt(index);
            }
        }

        private void Update()
        {
            switch (state)
            {
                case State.PlayerControl:
                    CharacterControl();
                    break;
                case State.DialogControl:
                    DialogControl();
                    break;
                case State.CaseDiaryControl:
                    CaseDiaryControl();
                    break;
            }
        }

        private void CaseDiaryControl()
        {
            if (Input.GetKeyUp(GameData.keyCodeCaseDiary))
            {
                caseDiary.NextCommand = GameData.keyCodeCaseDiary;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                // 증거 확인
            }
            else
            {
                caseDiary.NextCommand = KeyCode.None;
            }
        }

        private void DialogControl()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                dialogue.NextCommand = KeyCode.Space;
            }
            else
            {
                dialogue.NextCommand = KeyCode.None;
            }
        }

        private void CharacterControl()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                playerControl.NextMoveCommand = Vector3.up;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                playerControl.NextMoveCommand = Vector3.down;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                playerControl.NextMoveCommand = Vector3.left;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                playerControl.NextMoveCommand = Vector3.right;
            }
            else
            {
                playerControl.NextMoveCommand = Vector3.zero;
            }

            if (Input.GetKeyUp(GameData.keyCodeInteract))
            {
                playerControl.NextFunctionCommand = GameData.keyCodeInteract;
            }
            else if (Input.GetKeyUp(GameData.keyCodeCaseDiary))
            {
                playerControl.NextFunctionCommand = GameData.keyCodeCaseDiary;
            }
            else if (Input.GetKeyUp(GameData.keyCodeGetEvidence))
            {
                playerControl.NextFunctionCommand = GameData.keyCodeGetEvidence;
            }
            else
            {
                playerControl.NextFunctionCommand = KeyCode.None;
            }
        }

        private void Awake()
        {
            stack = new List<State>();
        }
    }

}