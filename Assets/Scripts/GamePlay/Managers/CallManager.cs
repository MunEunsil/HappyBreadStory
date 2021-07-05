using HappyBread.ETC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace HappyBread.GamePlay
{
    public class CallManager : MonoBehaviour
    {
        /// <summary>
        /// 추리하기 씬을 관리하는 클래스
        /// </summary>
        /// 

        private static CallManager _instance;

        public static CallManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = GameObject.Find("CallManager").GetComponent<CallManager>();
                }
                return _instance;
            }
        }

        public GameObject startImage;
        public bool stratImage = true;

        public GameObject content;//증거 넣어줄 곳 

        public GameObject EvidenceDiary; //증거 제출용 다이어리 
        public GameObject SuspectDiary; // 범인 지목용 다이어리 


        //각각의 사건의 활성화 여부
        public bool strawCaseActive = true;
        public bool hoduCaseActive = true;
        public bool jellyjellyCaseActive = true;

        //모든 사건 다 끝내면 3이고 엔딩
        public int solveCase = 0;
        

        //각각의 사건 비활성화 이미지 
        //위의 caseActive변수가 false가 되면 setActive(true)
        public GameObject strawIsActive;
        public GameObject hoduIsActive;
        public GameObject jellyjellyIsActive;



        //증거 
        public List<GameObject> evidenceObject = new List<GameObject>();
        public string evidenceArrName;
        public GameObject[] textObject = new GameObject[2];

        //텍스트 커서? 
        public int text1 = 0;
        public int text2 = 0;

        //현재 진행중인 캐릭터 이름  
        private string characterName;

        //어떤 사건을 진행중인지 
        public bool selectStrawCase = false;
        public bool selectHoduCase = false;
        public bool selectJellyJellyCase = false;

        //대화가 끝나면 알려줄 변수 
        public bool CallDialogueDone = false; // true : 대화 끝 , false : 대화 중  

        //증거 박스 선택 
        public bool evidenceBox1 = false;
        public bool evidenceBox2 = false;


        //오답기회 
        private int WrongAnswerNum = 0;

        //선택한 증거 박스 보여주는 ui
        public GameObject evidenceBoxObj1;
        public GameObject evidenceBoxObj2;
        
        //선택한 증거 채우기 
        public GameObject choiceEvidence1;
        public GameObject choiceEvidence2;

        //선택한 증거에 해당하는 텍스트 소스 불러오기위함
        public string selectEvidence1;
        public string selectEvidence2;

        //지목한 범인 
        public string selectSuspect;

        private string dialogueName;

        //사고사/ 타살 증거선택 했는지 체크
        public bool firstAskDone = false; //이게 true가 되면 범인 고르는 증거를 보여줘야함

        void Start()
        {
            solveCase = 0;
            WrongAnswerNum = 0;
            selectStrawCase = false;
            selectHoduCase = false;
            selectJellyJellyCase = false;

            DataManager.Instance.callStart = true;
        }


        // Update is called once per frame
        void Update()
        {

        }

        public void strawCaseClick()
        {
            //straw 사건을 클릭
            if (strawCaseActive == true) // 사건이 활성화 되어 있음
            {
                selectStrawCase = true;
                Debug.Log(selectStrawCase);

                //딸기잼 사건 추리

                DataManager.Instance.Choice_StrawCase = true;

                //GameModel.Instance.checkDiaryDialogue.checkDialoge("CallSceneStrawCase1");
                GameModel.Instance.EventManager.AddBlockingEvent(new CallDialogueEvent("CallSceneStrawCase1"));

 
                //CallSceneStrawCase1

            }
            else // 비활성화
            {
                //추리할 수 없는 사건입니다.
                Debug.Log("잠겨있는 사건입니다.");
            }
        }

        public void hoduCaseClick()
        {
            //호두 사건을 클릭
            if (hoduCaseActive == true) // 사건이 활성화 되어 있음
            {
                selectHoduCase = true;

                //호두 사건 추리
                DataManager.Instance.Choice_HoduCase = true;
                GameModel.Instance.EventManager.AddBlockingEvent(new CallDialogueEvent("CallSceneStrawCase1"));


            }
            else // 비활성화
            {
                //추리할 수 없는 사건입니다. 
            }
        }

        public void jellyjellyCaseClick()
        {
            //호두 사건을 클릭
            if (jellyjellyCaseActive == true) // 사건이 활성화 되어 있음
            {
                selectJellyJellyCase = true;

                //호두 사건 추리
                DataManager.Instance.Choice_JellyjellyCase = true;
                GameModel.Instance.EventManager.AddBlockingEvent(new CallDialogueEvent("CallSceneStrawCase1"));


            }
            else // 비활성화
            {
                //추리할 수 없는 사건입니다. 
            }
        }
        public void RenderEvidence()
        {
            //기존에 있던것 지우기 
            //evidenceObject.Clear();
            choiceEvidence1.SetActive(false);
            choiceEvidence2.SetActive(false);
            choiceEvidence1.GetComponent<Image>().sprite = null;
            choiceEvidence2.GetComponent<Image>().sprite = null;

            for (int i = 0; i < 6; i++)
            {
                evidenceObject[i].GetComponent<Image>().sprite = null;
            }

            if (selectStrawCase == true) //딸기사건
            {
                RenderText1();
                RenderText2();

                if (firstAskDone == false) //사고사/ 타살 증거
                {
                    Debug.Log("딸기 사고/ 타살 증거 렌더");
                    firstAskDone = true;
                    for (int i = 0; i < 6; i++)
                    {
                        evidenceObject[i].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.strawCaseEvidence1[i]);
                    }
                }
                else //범인 지목 증거 
                {
                    firstAskDone = false;
                    Debug.Log("딸기범인지목 증거 렌더");
                    for (int i = 0; i < 6; i++)
                    {
                        evidenceObject[i].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.strawCaseEvidence2[i]);
                    }
                }

            }
            else if (selectHoduCase == true)
            {
                RenderText1();
                RenderText2();
                Debug.Log("호두사건 클릭");

                if (firstAskDone == false) //사고사/ 타살 증거
                {
                    firstAskDone = true;
                    Debug.Log("호두 사고/타살 증거 렌더");
                    for (int i = 0; i < 6; i++)
                    {
                        evidenceObject[i].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.hoduCaseEvidence1[i]);
                    }
                }
                else //범인 지목 증거 
                {
                    firstAskDone = false;
                    Debug.Log("호두범인지목 증거 렌더");
                    for (int i = 0; i < 6; i++)
                    {
                        evidenceObject[i].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.hoduCaseEvidence2[i]);
                    }
                }
            }
            else if (selectJellyJellyCase == true)
            {
                RenderText1();
                RenderText2();

                if (firstAskDone == false) //사고사/ 타살 증거
                {
                    for (int i = 0; i < 6; i++)
                    {
                        evidenceObject[i].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.jellyjellyCaseEvidence1[i]);
                    }
                }
                else //범인 지목 증거 
                {
                    for (int i = 0; i < 6; i++)
                    {
                        evidenceObject[i].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.jellyjellyCaseEvidence2[i]);
                    }
                }
            }

        }


        public void RenderText1()
        {
            if (selectStrawCase == true)
            {
                if (firstAskDone == false) //사고사/ 타살 증거
                {
                    textObject[0].GetComponent<Text>().text = DataManager.Instance.strawCaseText1[text1];
                }
                else //범인지목
                {
                    textObject[0].GetComponent<Text>().text = DataManager.Instance.strawCaseText11[text1];
                }
            }
            else if (selectHoduCase == true)
            {
                if (firstAskDone == false) //사고사/ 타살 증거
                {
                    textObject[0].GetComponent<Text>().text = DataManager.Instance.hoduCaseText1[text1];
                }
                else //범인지목
                {
                    textObject[0].GetComponent<Text>().text = DataManager.Instance.hoduCaseText11[text1];
                }
                
            }
            else if (selectJellyJellyCase == true)
            {
                if (firstAskDone == false) //사고사/ 타살 증거
                {
                    textObject[0].GetComponent<Text>().text = DataManager.Instance.jellyjellyCaseText1[text1];
                }
                else //범인지목
                {
                    textObject[0].GetComponent<Text>().text = DataManager.Instance.jellyjellyCaseText11[text1];
                }
            }

        }
        public void CaseOff()
        {

            //현재 진행하고 있던 변수 false 
            if (selectStrawCase == true)
            {
                strawCaseActive = false;
                selectStrawCase = false;
                strawIsActive.SetActive(true);

            }
            else if (selectHoduCase == true)
            {
                hoduCaseActive = false;
                selectHoduCase = false;
                hoduIsActive.SetActive(true);
            }
            else if (selectJellyJellyCase==true)
            {
                jellyjellyCaseActive = false;
                selectJellyJellyCase = false;
                jellyjellyIsActive.SetActive(true);
            }

        }
        public void RenderText2()
        {
            if (selectStrawCase == true)
            {
                if (firstAskDone == false) //사고사/ 타살 증거
                {
                    textObject[1].GetComponent<Text>().text = DataManager.Instance.strawCaseText2[text2];
                }
                else //범인지목
                {
                    textObject[1].GetComponent<Text>().text = DataManager.Instance.strawCaseText22[text2];
                }
            }
            else if (selectHoduCase == true)
            {
                if (firstAskDone == false) //사고사/ 타살 증거
                {
                    textObject[1].GetComponent<Text>().text = DataManager.Instance.hoduCaseText2[text2];
                }
                else //범인지목
                {
                    textObject[1].GetComponent<Text>().text = DataManager.Instance.hoduCaseText22[text2];
                }
            }
            else if (selectJellyJellyCase == true)
            {
                if (firstAskDone == false) //사고사/ 타살 증거
                {
                    textObject[1].GetComponent<Text>().text = DataManager.Instance.hoduCaseText2[text2];
                }
                else //범인지목
                {
                    textObject[1].GetComponent<Text>().text = DataManager.Instance.hoduCaseText22[text2];
                }
            }
        }

        public void  LoadEnding()
        {
            GameModel.Instance.EffectManager.FadeIn();
            //SceneManager.LoadScene("Ending", LoadSceneMode.Additive);
            GameModel.Instance.MapManager.ChangeMap("Ending");
           // SceneManager.UnloadSceneAsync("CallEvent");

        }



        public void OkBtnDialogue()
        {
            //증거선택창에서 ok 버튼을 눌렀을 때 대화 불러옴 
            //타살일 때 : Kill_선택지1_증거1_증거2_선택지2
            //사고일 때 : Suicide_선택지1_증거_증거2_선택지2
            if (DataManager.Instance.isSuicide == true) // 타살
            {
                
                dialogueName = "Kill_" + text1 + "_" + selectEvidence1 + "_" + selectEvidence2 + "_" + text2;

                Debug.Log(dialogueName);
                if (dialogueName == "Kill_0_난간_리본_0") //straw 타살 정답
                {
                    //증거선택 이후 범인지목 대화가 나와야함 
                    //범인 지목 대화가 나오도록 만들기 
                    GameModel.Instance.EventManager.AddBlockingEvent(new Call_criminalChoiceEvent("kill_straw_correctAnswer"));

                }
                else if (dialogueName == "Kill_0_리본_난간_0") //straw 타살 정답
                {
                    //증거선택 이후 범인지목 대화가 나와야함 
                    //범인 지목 대화가 나오도록 만들기 
                    GameModel.Instance.EventManager.AddBlockingEvent(new Call_criminalChoiceEvent("kill_straw_correctAnswer"));

                }
                else if (dialogueName == "Kill_0_난간_신문기사_0") //straw 범인+증거 정답
                {
                    //범인 정답이면 그냥 텍스트 나오고 끗 
                    CaseOff();
                    //strawCaseActive = false;
                    //selectStrawCase = false;
                    //strawIsActive.SetActive(true);

                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("suspect_straw_correctAnswer"));
                    DataManager.Instance.happyEnding = true;
                    solveCase++;

                }
                else if (dialogueName == "Kill_0_신문기사_난간_0") //straw 범인+증거 정답
                {
                    //범인 정답이면 그냥 텍스트 나오고 끗 
                    CaseOff();
                    //strawCaseActive = false;
                    //selectStrawCase = false;
                    //strawIsActive.SetActive(true);

                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("suspect_straw_correctAnswer"));
                    DataManager.Instance.happyEnding = true;
                    solveCase++;

                }
                else if (dialogueName == "Kill_0_냉동창고_열쇠_난간_0") //hodu 타살 정답
                {
                    GameModel.Instance.EventManager.AddBlockingEvent(new Call_criminalChoiceEvent("kill_hodu_correctAnswer"));
                }
                else if (dialogueName == "Kill_0_난간_냉동창고_열쇠_0")
                {
                    GameModel.Instance.EventManager.AddBlockingEvent(new Call_criminalChoiceEvent("kill_hodu_correctAnswer"));
                }
                else if (dialogueName == "Kill_0_리본_쪽지_0") //hodu 범인정답
                {
                    CaseOff();
                    //strawCaseActive = false;
                    //selectStrawCase = false;
                    //strawIsActive.SetActive(true);

                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("suspect_hodu_correctAnswer"));
                    DataManager.Instance.happyEnding = true;
                    solveCase++;
                }
                else if (dialogueName == "Kill_0_쪽지_리본_0")
                { 
                    CaseOff();
                    //strawCaseActive = false;
                    //selectStrawCase = false;
                    //strawIsActive.SetActive(true);

                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("suspect_hodu_correctAnswer"));
                    DataManager.Instance.happyEnding = true;
                    solveCase++;
                }
                else if (dialogueName == "Kill_0_젤리젤리의흔적_증언_0") //jellyjelly 타살 정답
                {
                    GameModel.Instance.EventManager.AddBlockingEvent(new Call_criminalChoiceEvent("kill_jellyjelly_correctAnswer"));
                }
                else if (dialogueName == "Kill_0_증언_젤리젤리의흔적_0") //jellyjelly 타살 정답
                {
                    GameModel.Instance.EventManager.AddBlockingEvent(new Call_criminalChoiceEvent("kill_jellyjelly_correctAnswer"));
                }
                else if (dialogueName == "Kill_0_젤리화장품_젤리젤리일기장_0") //jellyjelly 범인정답
                {
                    CaseOff();
                    //strawCaseActive = false;
                    //selectStrawCase = false;
                    //strawIsActive.SetActive(true);

                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("suspect_jellyjelly_correctAnswer"));
                    DataManager.Instance.happyEnding = true;
                    solveCase++;
                }
                else if (dialogueName == "Kill_0_젤리젤리일기장_젤리화장품_0") //jellyjelly 범인정답
                {
                    CaseOff();
                    //strawCaseActive = false;
                    //selectStrawCase = false;
                    //strawIsActive.SetActive(true);

                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("suspect_jellyjelly_correctAnswer"));
                    DataManager.Instance.happyEnding = true;
                    solveCase++;
                }
                else // 오답
                {
                    GameModel.Instance.EventManager.AddBlockingEvent(new callDialogueBasic("Call_wrongAnswer"));
                    if (WrongAnswerNum < 2)
                    {
                        DataManager.Instance.Choice_StrawCase = true;
                        EvidenceDiary.SetActive(true);
                        RenderEvidence();
                        RenderText1();
                        RenderText2();
                        WrongAnswerNum++;
                    }
                    else
                    {
                        CaseOff();
                        solveCase = 3;
                        DataManager.Instance.happyEnding = false;
                        EvidenceDiary.SetActive(false);
                        // LoadEnding();

                    }
                    

                }

            }
            else if(DataManager.Instance.isSuicide == false) //사고사
            {

                GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(dialogueName));

            }
        }

    }
}
