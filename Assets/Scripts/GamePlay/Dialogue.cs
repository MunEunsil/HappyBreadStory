using HappyBread.Core;
using HappyBread.ETC;
using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HappyBread.GamePlay
{
    /// <summary>
    /// 대화를 저장하고 있으며 관리하는 클래스.
    /// </summary>
    public class Dialogue : MonoBehaviour
    {
        public Image characterUI;
        public Image backgroundUI;
        public Text textUI;
        public float typingIdleTime = 0.05f;
        public KeyCode NextCommand;
        public Event ConnectedEvent { get; set; }

        private Coroutine typingCoroutine = null;
        private List<string> currentDialogue;
        private int currentIndex;
        private string currentText;

        public int answerIndex = -1;   //AnswerIndex에 해당하는 answer을 출력하기 위함.
        public QuestionBox questionBox;

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
                    if (NextCommand == KeyCode.Escape)
                    {
                        Debug.Log("esc 누름");
                        End();
                    }
                    break;
                case State.Waiting:
                    if (NextCommand == KeyCode.Space)
                    {
                        if (state == State.Waiting)
                        {
                            Next();
                        }
                    }
                    else if (NextCommand == KeyCode.Escape)
                    {
                        Debug.Log("esc 누름");
                        End();
                    }
                    break;
                case State.Blocking:
                    if (NextCommand == KeyCode.Escape)
                    {
                        Debug.Log("esc 누름");
                        End();
                    }
                    break;
                case State.NonBlocking:
                    if (NextCommand == KeyCode.Space)
                    {
                        PrintAll();
                    }
                    else if (NextCommand == KeyCode.Escape)
                    {
                        Debug.Log("esc 누름");
                        End();
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
                GameModel.Instance.StateManager.ChangeState(new DialogueState());
                currentDialogue = dialogue;
                currentIndex = -1;
                state = State.Waiting;
                Next();

            }
        }

        public void Next()
        {
            if(state == State.Idle) // 대화가 들어있지 않으면 아무일도 일어나지 않는다.
            {
                return;
            }

            currentIndex++;
            if (currentIndex >= currentDialogue.Count) // 대화를 다 읽었을 경우 종료한다.
            {
                End();
                return;
            }

            string[] seperated = currentDialogue[currentIndex].Split(':'); // 텍스트 파일을 ':' 을 기준으로 분리한다.

            // flag
            // Message ->
            // 1번 인자[ flag ], 2번 인자 [ Background Name ], 3번 인자 [ Character Name ], 4번 인자 [ Message ]
            // Question ->
            // 1번 인자[ flag ], 2번 인자 [ Background Name ], 3번 인자 [ Character Name ], 4번 인자 [ Message ], 5번 인자 [ Question 1 ], 6번 인자 [ Question 2 ] , ...
            // Question의 내용은 인자에서 읽는다.
            string flag = seperated[0].Trim();

            switch (flag)
            {
                case "Message":
                    ShowMessage(seperated);
                    break;
                case "Question":
                    ShowQuestion(seperated);
                    break;
                case "Answer":        //플래그 추가 
                    ShowAnswerMessage(seperated);
                    break;
                case "Stair":
                    Stairs(seperated);
                    break;


            }

            NextCommand = KeyCode.None;
        }

        private void Stairs(string[] seperated) //계단.
        {

            int from = DataManager.Instance.floor;

            List<string> questions = new List<string>();

            // 질문 내용을 List에 추가한다.
            for (int index = 4; index < seperated.Length; index++)
            {
                questions.Add(seperated[index].Trim());
            }

            GameModel.Instance.QuestionBox.CreateSelector(questions);

            ShowMessage(seperated);

            //  answerIndex = questionBox.AnswerIndex;
          //  answerIndex = DataManager.Instance.select;

          //  Debug.Log(answerIndex);
            //if (answerIndex == 1) //지하 1 
            //{
            //    GameModel.Instance.FloorManager.ChangeFloor(from, 0, GameObject.FindObjectOfType<Stairs>().exitB1.transform.position);
            //    DataManager.Instance.floor = 0;//지하
            //}
            //else if (answerIndex == 2) //지상1
            //{
            //    GameModel.Instance.FloorManager.ChangeFloor(from, 1, GameObject.FindObjectOfType<Stairs>().exitF1.transform.position);
            //    DataManager.Instance.floor = 1;//1층
            //}
            //else if (answerIndex == 3)
            //{
            //    GameModel.Instance.FloorManager.ChangeFloor(from, 2, GameObject.FindObjectOfType<Stairs>().exitF2.transform.position);
            //    DataManager.Instance.floor = 2;
            //}
            //else if (answerIndex == 4)
            //{
            //    GameModel.Instance.FloorManager.ChangeFloor(from, 3, GameObject.FindObjectOfType<Stairs>().exitF3.transform.position);
            //    DataManager.Instance.floor = 3;
            //}

        }
        private void ShowAnswerMessage(string[] seperated)
        {
            string backgroundFileName = seperated[1].Trim();
            string characterFileName = seperated[2].Trim();

            Sprite backgroundSprite = ResourceLoader.LoadSprite(backgroundFileName);
            Sprite characterSprite = ResourceLoader.LoadSprite(characterFileName);

            if (backgroundSprite == null)
            {
                backgroundUI.enabled = false;
            }
            else
            {
                backgroundUI.enabled = true;
                backgroundUI.sprite = backgroundSprite;
            }

            if (characterSprite == null)
            {
                characterUI.enabled = false;
            }
            else
            {
                characterUI.enabled = true;
                characterUI.sprite = characterSprite;
            }
            answerIndex = questionBox.AnswerIndex;

            // 메세지 변환
            currentText = InjectVariable(seperated[3+answerIndex].Trim()); //3+amswerIndex 가 답변순서가 맞는지 확인 

            if (typingCoroutine != null)
            {
                StopCoroutine(typingCoroutine);
            }
            typingCoroutine = StartCoroutine(SmoothTyping(currentText));
        }


       
        private void ShowQuestion(string[] seperated)
        {

            int startIndex = 4;
            List<string> questions = new List<string>();

            // 질문 내용을 List에 추가한다.
            for (int index = startIndex; index < seperated.Length; index++)
            {
                questions.Add(seperated[index].Trim());
            }

            // Question Box 세팅
            GameModel.Instance.QuestionBox.CreateSelector(questions);

            // 메세지를 출력한다.
            ShowMessage(seperated);
        }

        private void ShowMessage(string[] seperated)
        {
            string backgroundFileName = seperated[1].Trim();
            string characterFileName = seperated[2].Trim();

            Sprite backgroundSprite = ResourceLoader.LoadSprite(backgroundFileName);
            Sprite characterSprite = ResourceLoader.LoadSprite(characterFileName);

            if (backgroundSprite == null)
            {
                backgroundUI.enabled = false;
            }
            else
            {
                backgroundUI.enabled = true;
                backgroundUI.sprite = backgroundSprite;
            }

            if (characterSprite == null)
            {
                characterUI.enabled = false;
            }
            else
            {
                characterUI.enabled = true;
                characterUI.sprite = characterSprite;
            }

            // 메세지 변환
            currentText = InjectVariable(seperated[3].Trim());

            if(typingCoroutine != null)
            {
                StopCoroutine(typingCoroutine);
            }
            typingCoroutine = StartCoroutine(SmoothTyping(currentText));
        }

        private void End()
        {
            state = State.Idle;
            currentIndex = -1;
            GameModel.Instance.StateManager.UndoState(); // Input 관리
            gameObject.SetActive(false); // UI 관리

            if (ConnectedEvent != null)
            {
                ConnectedEvent.End(); // 이벤트 매니저에게 알림
                ConnectedEvent = null;
            }
            return;
        }

        private void PrintAll()
        {
            if (state == State.NonBlocking)
            {
                StopCoroutine(typingCoroutine);
                state = State.Waiting;
                textUI.text = currentText;
                currentText = "";
                NextCommand = KeyCode.None;
            }
        }

        IEnumerator SmoothTyping(string text)
        {
            state = State.Blocking;
            textUI.text = "";
            foreach (var character in text)
            {
                if (textUI.text.Length == 3) // 글자를 3개까지 읽으면 모든 텍스트를 출력할 수 있게끔 상태를 변경한다.
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

        private string InjectVariable(string rawText)
        {
            string text = rawText.Replace("{playerName}", DataManager.Instance.PlayerName);
            return text;
        }

    }

}