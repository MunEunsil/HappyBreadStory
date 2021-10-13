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
        //public Image characterUI;
        public Image backgroundUI;
        public Text textUI;
        public float typingIdleTime = 0.05f;
        public KeyCode NextCommand;
        public Event ConnectedEvent { get; set; }

        public GameObject characterUI_;
        public GameObject backgroundUI_;
        public GameObject evidenceUI_;
        public GameObject playerUI_;

        //이름표
        public GameObject characterNameUI_;
        public Text characterNmaeText_;
        public GameObject playerNameUI_;
        public Text playerNmaeText_;



        public Text characterName;

        public bool dialogueDone = false;

        private Coroutine typingCoroutine = null;
        private List<string> currentDialogue;
        private int currentIndex;
        private string currentText;

        //public Image evidenceUI;

        //public Image playerUI;


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
            // 1번 인자[ flag ], 2번 인자 [ Background Name ],3번 인자[ 캐릭터or증거or플레이어 ],4번 인자 [ Character Name ], 5번 인자 [ Message ] 
            // Question ->
            // 1번 인자[ flag ], 2번 인자 [ Background Name ],3번 인자[ 캐릭터or증거or플레이어 ]  ,4번 인자 [ Character Name ], 4번 인자 [ Message ], 5번 인자 [ Question 1 ], 6번 인자 [ Question 2 ] , ...
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
            for (int index = 5; index < seperated.Length; index++)
            {
                questions.Add(seperated[index].Trim());
            }

            GameModel.Instance.QuestionBox.CreateSelector(questions);

            ShowMessage(seperated);


        }
        private void ShowAnswerMessage(string[] seperated)
        {
            string backgroundFileName = seperated[1].Trim();
            string characterFileName = seperated[3].Trim();

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
               // characterUI.enabled = false;
                characterUI_.SetActive(false);


            }
            else
            {
                //characterUI.enabled = true;
                //characterUI.sprite = characterSprite;
                characterUI_.SetActive(false);
                characterUI_.GetComponent<Image>().sprite = characterSprite;
            }
            answerIndex = questionBox.AnswerIndex;

            // 메세지 변환
            currentText = InjectVariable(seperated[4+answerIndex].Trim()); //3+amswerIndex 가 답변순서가 맞는지 확인 

            if (typingCoroutine != null)
            {
                StopCoroutine(typingCoroutine);
            }
            typingCoroutine = StartCoroutine(SmoothTyping(currentText));
        }


       
        private void ShowQuestion(string[] seperated)
        {

            int startIndex = 5;
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

        //이름표 이름 보여주기 위함 
        private void ShowNameTag(string name) 
        {
            //플레이어 이름 / npc 이름 
            string[] TagName = new string [2];
            TagName = name.Split('_');

            ///
            /// 대사 전부 수정할 일 있으면 그냥 캐릭터이름_ 이렇게 수정 
            /// 다만 이렇게 하면 이미지 이름도 전부 수정 
            /// 만약 대사 모두 다시 수정할 일이 있다면 츄라이
            ///
            switch (TagName[0])
            {
                case "컵케익":
                    characterNmaeText_.text = "컵케익";
                    break;
                case "소라빵":
                    characterNmaeText_.text = "초롱";
                    break;
                case "크로아상":
                    characterNmaeText_.text = "크로 경장";
                    break;
                case "도넛":
                    characterNmaeText_.text = "두나";
                    break;
                case "호두":
                    characterNmaeText_.text = "워넷";
                    break;
                case "땅콩잼":
                    characterNmaeText_.text = "피넛스";
                    break;
                case "젤리":
                    characterNmaeText_.text = "젤리";
                    break;
                case "젤리젤리":
                    characterNmaeText_.text = "젤리젤리";
                    break;
                case "마카롱":
                    characterNmaeText_.text = "막가롱";
                    break;
                case "팬케이크":
                    characterNmaeText_.text = "핫케이";
                    break;
                case "딸기잼":
                    characterNmaeText_.text = "산딸기";
                    break;
                case "꽈배기":
                    characterNmaeText_.text = "곽백이";
                    break;

            }
        }

        private void ShowMessage(string[] seperated)
        {
            string backgroundFileName = seperated[1].Trim();
            string characterFileName = seperated[3].Trim(); //캐릭터나 증거의 이미지
            string isEvidence = seperated[2].Trim();

            if (isEvidence == "Evidence") //증거일 때
            {
                Sprite backgroundSprite = ResourceLoader.LoadSprite(backgroundFileName);
                Sprite EvidenceSprite = ResourceLoader.LoadSprite(characterFileName);

                //playerUI.enabled = false;
                //characterUI.enabled = false;
                characterUI_.SetActive(false);
                playerUI_.SetActive(false);
                characterNameUI_.SetActive(false);

                if (backgroundSprite == null)
                {
                    backgroundUI.enabled = false;
                    backgroundUI_.SetActive(false);
                }
                else
                {
                  //  backgroundUI.enabled = true;
                    backgroundUI_.SetActive(true);
                    backgroundUI_.GetComponent<Image>().sprite = backgroundSprite;
                    //backgroundUI.sprite = backgroundSprite;
                }

                if (EvidenceSprite == null)
                {
                    evidenceUI_.SetActive(false);
                    //evidenceUI.enabled = false;
                }
                else
                {
                  //  characterUI.enabled = true;
                    //evidenceUI.sprite = EvidenceSprite;
                    evidenceUI_.SetActive(true);
                    evidenceUI_.GetComponent<Image>().sprite = EvidenceSprite;
                }

                // 메세지 변환
                currentText = InjectVariable(seperated[4].Trim());

                if (typingCoroutine != null)
                {
                    StopCoroutine(typingCoroutine);
                }
                typingCoroutine = StartCoroutine(SmoothTyping(currentText));
            }
            else if (isEvidence == "Player") //플레이어 대화 일 때
            {
                Sprite backgroundSprite = ResourceLoader.LoadSprite(backgroundFileName);
                Sprite playerSprite = ResourceLoader.LoadSprite(characterFileName);

                playerNmaeText_.text= DataManager.Instance.PlayerName;
            

                //characterUI.enabled = false;
                //evidenceUI.enabled = false;
                characterUI_.SetActive(false);
                evidenceUI_.SetActive(false);
                characterNameUI_.SetActive(false);



                if (backgroundSprite == null)
                {
                    backgroundUI.enabled = false;
                }
                else
                {
                    backgroundUI.enabled = true;
                    backgroundUI.sprite = backgroundSprite;
                }

                if (playerSprite == null)
                {
                   // playerUI.enabled = false;
                    playerUI_.SetActive(false);
                }
                else
                {
                    //  characterUI.enabled = true;
                    //playerUI.sprite = playerSprite;
                    playerUI_.SetActive(true);
                    playerNameUI_.SetActive(true);
                    playerUI_.GetComponent<Image>().sprite = playerSprite;
                }

                // 메세지 변환
                currentText = InjectVariable(seperated[4].Trim());

                if (typingCoroutine != null)
                {
                    StopCoroutine(typingCoroutine);
                }
                typingCoroutine = StartCoroutine(SmoothTyping(currentText));
            }
            else //캐릭터 대화일 때
            {
                playerUI_.SetActive(false);
                evidenceUI_.SetActive(false);
                Sprite backgroundSprite = ResourceLoader.LoadSprite(backgroundFileName);
                Sprite characterSprite = ResourceLoader.LoadSprite(characterFileName);

                //playerUI.enabled = false;
                //evidenceUI.enabled = false;

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
                    //characterUI.enabled = false;
                    characterUI_.SetActive(false);
                    characterNameUI_.SetActive(false);
                }
                else
                {
                    //characterUI.enabled = true;
                    //characterUI.sprite = characterSprite;
                    ShowNameTag(seperated[3]);

                    characterUI_.SetActive(true);
                    characterNameUI_.SetActive(true);
                    characterUI_.GetComponent<Image>().sprite = characterSprite;


                }

                // 메세지 변환
                currentText = InjectVariable(seperated[4].Trim());

                if (typingCoroutine != null)
                {
                    StopCoroutine(typingCoroutine);
                }
                typingCoroutine = StartCoroutine(SmoothTyping(currentText));
            }


        }

        private void End()
        {
            state = State.Idle;
            currentIndex = -1;
            GameModel.Instance.StateManager.UndoState(); // Input 관리
            gameObject.SetActive(false); // UI 관리

            dialogueDone = true;
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
            dialogueDone = false;
        }

        private string InjectVariable(string rawText)
        {
            string text = rawText.Replace("{playerName}", DataManager.Instance.PlayerName);
            return text;
        }

    }

}