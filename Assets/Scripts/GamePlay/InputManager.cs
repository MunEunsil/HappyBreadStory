using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HappyBread.GamePlay;
using System;
using HappyBread.Core;

namespace HappyBread.GamePlay
{
    /// <summary>
    /// Input의 제어를 담당하는 매니저 클래스.
    /// </summary>
    public class InputManager : MonoBehaviour
    {
        public Player player;
        public Dialogue dialogue;
        public CaseDiary caseDiary;
        public QuestionBox questionBox;

        private List<State> stack; // 이전 상태를 저장합니다.


        public enum State
        {
            PlayerControl,
            DialogControl,
            CaseDiaryControl,
            QuestionManagerControl,
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
                case State.QuestionManagerControl:
                    QuestionManagerControl();
                    break;
            }
        }

        private void QuestionManagerControl()
        {
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                questionBox.NextMoveCommand = Vector3.up;
            }
            else if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                questionBox.NextMoveCommand = Vector3.down;
            }
            else
            {
                questionBox.NextMoveCommand = Vector3.zero;
            }

            if (Input.GetKeyUp(GameData.KeyCodeSelect))
            {
                questionBox.NextCommand = GameData.KeyCodeSelect;
            }
            else
            {
                questionBox.NextCommand = KeyCode.None;
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
                player.NextMoveCommand = Vector3.up;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                player.NextMoveCommand = Vector3.down;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                player.NextMoveCommand = Vector3.left;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                player.NextMoveCommand = Vector3.right;
            }
            else
            {
                player.NextMoveCommand = Vector3.zero;
            }

            if (Input.GetKeyUp(GameData.keyCodeInteract))
            {
                player.NextFunctionCommand = GameData.keyCodeInteract;
            }
            else if (Input.GetKeyUp(GameData.keyCodeCaseDiary))
            {
                player.NextFunctionCommand = GameData.keyCodeCaseDiary;
            }
            else
            {
                player.NextFunctionCommand = KeyCode.None;
            }
        }

        private void Awake()
        {
            stack = new List<State>();
        }
    }

}