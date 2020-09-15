using HappyBread.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace HappyBread.GamePlay
{
    public class Selector : MonoBehaviour
    {
        public GameObject questionPrefab;
        public Vector3 NextMoveCommand;
        public KeyCode NextCommand;
        public int answerIndex = -1; // 해당 인덱스를 통해 선택한 답변이 무엇인지 알아낸다.

        private enum State
        {
            Idle,
            Active
        }

        private State state = State.Idle;
        private List<GameObject> questions;
        private float questionHeight = 50f;
        private float questionMargin = 1f;
        private int selectedIndex = 0;

        public void CreateSelector(List<string> rawQuestions)
        { 
            selectedIndex = 0;
            answerIndex = -1;

            float totalHeight = (rawQuestions.Count - 1) * (questionHeight + questionMargin); // selector가 차지하는 공간의 총 높이
            for (int index = 0; index < rawQuestions.Count; index++)
            {
                // 1. 질문을 받아 하나씩 question을 만든다.
                GameObject newQuestion = Instantiate<GameObject>(questionPrefab, transform);
                newQuestion.GetComponent<Question>().SetText(rawQuestions[index]); // 문자열 입력
                questions.Add(newQuestion);

                // 2. 해당 사항을 적절히 배치한다.
                RectTransform rt = newQuestion.GetComponent<RectTransform>();
                rt.anchoredPosition = new Vector2(0f, totalHeight - index * (questionHeight + questionMargin));
            }
            Render();
        }

        private void Update()
        {
            switch (state)
            {
                case State.Idle:
                    IdleState();
                    break;
                case State.Active:
                    ActiveState();
                    break;
                default:
                    break;
            }
        }

        private void ActiveState()
        {
            // 방향키 커맨드를 받고 인덱스를 변화시킨다.
            ChangeSelectedIndex(NextMoveCommand);

            // 선택키 커맨드를 받고 질문을 수행한다.
            Select(NextCommand);
        }

        private void Select(KeyCode nextCommand)
        {
            if (nextCommand == GameData.KeyCodeSelect)
            {
                // 선택지 제거
                foreach(GameObject question in questions)
                {
                    Destroy(question.gameObject);
                }
                questions.Clear();

                answerIndex = selectedIndex;
                GameModel.Instance.inputManager.UndoState();
                gameObject.SetActive(false);
            }
            else
            {
                return;
            }
        }

        private void ChangeSelectedIndex(Vector3 nextMoveCommand)
        {
            int flag;

            if (nextMoveCommand == Vector3.up)
            {
                flag = -1;
            }
            else if (nextMoveCommand == Vector3.down)
            {
                flag = 1;
            }
            else
            {
                return;
            }

            selectedIndex = (selectedIndex + flag) % questions.Count;
            selectedIndex = selectedIndex < 0 ? questions.Count - 1 : selectedIndex;
            Render();
        }

        private void Render()
        {
            for (int index = 0; index < questions.Count; index++)
            {
                if (index == selectedIndex)
                {
                    questions[index].GetComponent<Question>().SetBackgroundAlpha(200f / 255f);
                }
                else
                {
                    questions[index].GetComponent<Question>().SetBackgroundAlpha(80f / 255f);
                }
            }
        }

        private void IdleState()
        {
            if (questions.Count > 0)
            {
                state = State.Active;
            }
        }

        private void Awake()
        {
            questions = new List<GameObject>();
        }

        public void Test()
        {
            gameObject.SetActive(true);
            GameModel.Instance.inputManager.ChangeState(InputManager.State.SelectorControl);
            List<string> test = new List<string>();
            test.Add("1. 안녕 나는 재상");
            test.Add("2. 안녕 나는 재중");
            test.Add("3. 안녕 나는 재하");
            CreateSelector(test);
        }
    }
}