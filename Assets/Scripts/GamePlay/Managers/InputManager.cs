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
        public enum State
        {
            OpeningControl,
            PlayerControl,
            DialogueControl,
            CaseDiaryControl,
            QuestionBoxControl,
            Pause
        }

        [SerializeField]
        private State state;
        /// <summary>
        /// 상태를 지정합니다.
        /// </summary>
        /// <param name="state">InputManager의 상태</param>
        public void SetState(State state)
        {
            this.state = state;
        }

        private void Update()
        {
            switch (state)
            {
                case State.PlayerControl:
                    CharacterControl();
                    break;
                case State.DialogueControl:
                    DialogControl();
                    break;
                case State.CaseDiaryControl:
                    CaseDiaryControl();
                    break;
                case State.QuestionBoxControl:
                    QuestionBoxControl();
                    break;
            }
        }

        private void QuestionBoxControl()
        {
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                GameModel.Instance.QuestionBox.NextMoveCommand = Vector3.up;
            }
            else if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                GameModel.Instance.QuestionBox.NextMoveCommand = Vector3.down;
            }
            else
            {
                GameModel.Instance.QuestionBox.NextMoveCommand = Vector3.zero;
            }

            if (Input.GetKeyUp(GlobalGameData.KeyCodeSelect))
            {
                GameModel.Instance.QuestionBox.NextCommand = GlobalGameData.KeyCodeSelect;
            }
            else
            {
                GameModel.Instance.QuestionBox.NextCommand = KeyCode.None;
            }
        }

        private void CaseDiaryControl()
        {
            if (Input.GetKeyUp(GlobalGameData.keyCodeCaseDiary))
            {
                GameModel.Instance.CaseDiary.NextCommand = GlobalGameData.keyCodeCaseDiary;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                // 증거 확인
            }
            else
            {
                GameModel.Instance.CaseDiary.NextCommand = KeyCode.None;
            }
        }

        private void DialogControl()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                GameModel.Instance.Dialogue.NextCommand = KeyCode.Space;
            }
            else
            {
                GameModel.Instance.Dialogue.NextCommand = KeyCode.None;
            }
        }

        private void CharacterControl()
        {
            if(GameModel.Instance.Player == null)
            {
                return;
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                GameModel.Instance.Player.NextMoveCommand = Vector3.up;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                GameModel.Instance.Player.NextMoveCommand = Vector3.down;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                GameModel.Instance.Player.NextMoveCommand = Vector3.left;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                GameModel.Instance.Player.NextMoveCommand = Vector3.right;
            }
            else // TODO : 아무것도 안눌렸을 때라는 표현이 아닌 것 같다. 애매하다 고치기 필요.
            {
                GameModel.Instance.Player.NextMoveCommand = Vector3.zero;
            }

            if (Input.GetKeyUp(GlobalGameData.keyCodeInteract))
            {
                GameModel.Instance.Player.NextFunctionCommand = GlobalGameData.keyCodeInteract;
            }
            else if (Input.GetKeyUp(GlobalGameData.keyCodeCaseDiary))
            {
                GameModel.Instance.Player.NextFunctionCommand = GlobalGameData.keyCodeCaseDiary;
            }
            else
            {
                GameModel.Instance.Player.NextFunctionCommand = KeyCode.None;
            }
        }
    }

}