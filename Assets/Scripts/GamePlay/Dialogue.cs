using HappyBread.Core;
using HappyBread.ETC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HappyBread.GamePlay
{
    public class Dialogue : MonoBehaviour
    {
        public Image imageUI;
        public Text textUI;
        public float typingIdleTime = 0.05f;
        public KeyCode NextCommand;

        private Coroutine typingCoroutine;
        private List<string> currentDialogue;
        private int currentIndex;
        private string currentText;

        private enum State
        {
            Idle,       // Dialogue가 들어와있지 않은 상태
            Waiting,    // 대화가 진행 중이며, 한 줄의 대화가 끝나 입력을 기다리고 있는 상태
            Blocking,   // 대화가 진행 중이며, 대화를 넘길 수 없는 상태
            NonBlocking // 대화가 진행 중이며, 대화를 넘길 수 있는 상태
        }
        private State state;

        private void Update()
        {
            switch (state)
            {
                case State.Idle:
                    break;
                case State.Waiting:
                    if (NextCommand == KeyCode.Space)
                    {
                        Next();
                    }
                    break;
                case State.Blocking:
                    break;
                case State.NonBlocking:
                    if (NextCommand == KeyCode.Space)
                    {
                        PrintAll();
                    }
                    break;
                default:
                    break;
            }
        }

        public void Execute(List<string> dialogue)
        {
            if (state == State.Idle)
            {
                currentDialogue = dialogue;
                currentIndex = -1;
                state = State.Waiting;
                Next();
            }
        }

        private void Next()
        {
            if (state == State.Waiting)
            {
                currentIndex++;
                if (currentIndex >= currentDialogue.Count) // 대화를 다 읽었을 경우 종료한다.
                {
                    state = State.Idle;
                    GameModel.Instance.inputManager.UndoState();
                    gameObject.SetActive(false);
                    return;
                }

                string[] seperated = currentDialogue[currentIndex].Split(':');

                string imageFileName = seperated[0].Trim();
                Sprite sprite = ResourceLoader.LoadSprite(imageFileName);
                if (sprite == null)
                {
                    imageUI.enabled = false;
                }
                else
                {
                    imageUI.enabled = true;
                    imageUI.sprite = sprite;
                }
                currentText = seperated[1].Trim();

                typingCoroutine = StartCoroutine(SmoothTyping(currentText));
            }
        }

        private void PrintAll()
        {
            if (state == State.NonBlocking)
            {
                StopCoroutine(typingCoroutine);
                state = State.Waiting;
                textUI.text = currentText;
                currentText = "";
            }
        }

        IEnumerator SmoothTyping(string text)
        {
            state = State.Blocking;
            textUI.text = "";
            foreach (var character in text)
            {
                if (textUI.text.Length == 3)
                {
                    state = State.NonBlocking;
                }
                textUI.text += character;
                yield return new WaitForSeconds(typingIdleTime);
            }
            state = State.Waiting;
        }

        private void Awake()
        {
            state = State.Idle;
            NextCommand = KeyCode.None;
        }
    }

}