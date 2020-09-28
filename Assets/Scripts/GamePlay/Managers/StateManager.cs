using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    /// <summary>
    /// 현재 State를 토대로 게임의 구성을 변경하는 매니저 클래스
    /// </summary>
    public class StateManager : MonoBehaviour
    {
        private List<IState> stack; // 이전 상태를 저장합니다.
        IState state; // 현재 진행되고 있는 상태

        // 스택에 현재 상태를 저장하고 인자로 받은 상태로 변경합니다.
        public void ChangeState(IState state)
        {
            if(state == null)
            {
                return;
            }
            stack.Add(this.state);
            this.state = state;
            state.Change();
        }

        /// <summary>
        /// 현재 스택을 초기화하고, 상태를 지정합니다.
        /// </summary>
        /// <param name="state">InputManager의 상태</param>
        public void SetState(IState state)
        {
            if (state == null)
            {
                return;
            }
            stack.Clear();
            this.state = state;
            state.Change();
        }

        // 이전 상태로 되돌립니다.
        public void UndoState()
        {
            if (stack.Count > 0)
            {
                int index = stack.Count - 1;
                this.state = stack[index];
                this.state.Change();
                stack.RemoveAt(index);
            }
        }

        public void Resume()
        {
            if(state is PauseState)
            {
                DataManager.Instance.IsPause = false;
                GameModel.Instance.StateManager.UndoState();
            }
        }

        private void Awake()
        {
            stack = new List<IState>();
        }
    }
}
