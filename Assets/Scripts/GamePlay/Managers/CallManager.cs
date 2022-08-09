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
        /// 추리하기 씬을 관리하는 클래스(은실 -2021.05.01)
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

        // 각 사건 버튼 
        public GameObject strawButton;
        public GameObject hoduButton;
        public GameObject jellyjellyButton;



        //모든 사건 다 끝내면 3이고 엔딩
        public int solveCase = 0;

        public bool solveFail = false; //true이면 오답

        //각각의 사건 비활성화 이미지 
        //위의 caseActive변수가 false가 되면 setActive(true)
        public GameObject strawIsActive;
        public GameObject hoduIsActive;
        public GameObject jellyjellyIsActive;



        //증거 
        public List<GameObject> evidenceObject = new List<GameObject>();
        public string evidenceArrName;
        public GameObject[] textObject = new GameObject[2];

        //증거선택화면 증거 좌/우 움직이기위한 변수
        //증거선택 열때마다 초기화해줘야함 
        int j = 0;  //증거 칸 index 
        bool rightEnd = false; //오른쪽으로 더이상 클릭 불가능하게 하기 위함 

        public int EAF = 0; //EvidenceArrFront
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
        public int WrongAnswerNum = 0;

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

        public bool IsChoiceSuspect = false; //범인선택중일 때 true 아닐때 끄기 , 


        //사고사/ 타살 증거선택 했는지 체크
        public bool firstAskDone = false; //이게 true가 되면 범인 고르는 증거를 보여줘야함

        void Start()
        {
            GameModel.Instance.AudioManager.PlayBackgroundAudio();

            solveCase = 0;
            WrongAnswerNum = 0;
            selectStrawCase = false;
            selectHoduCase = false;
            selectJellyJellyCase = false;
            solveFail = false;
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
               // Debug.Log(selectStrawCase);

                //딸기잼 사건 추리

                DataManager.Instance.Choice_StrawCase = true;

                GameModel.Instance.EventManager.AddBlockingEvent(new CallDialogueEvent("CallSceneStrawCase1"));

            }
            else // 비활성화
            {
                //추리할 수 없는 사건입니다.
                //Debug.Log("잠겨있는 사건입니다.");
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
                GameModel.Instance.EventManager.AddBlockingEvent(new CallDialogueEvent("CallSceneHoduCase"));


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
                GameModel.Instance.EventManager.AddBlockingEvent(new CallDialogueEvent("CallSceneJellyjellyCase__"));


            }
            else // 비활성화
            {
                //추리할 수 없는 사건입니다. 
            }
        }

        /// <summary>
        /// 증거 보여주기 수정 - 은실(2022.05.28)
        /// 기존 : 특정 증거만 습득되어있으면 보여줌 (없으면 빈칸)
        /// 변경 : 습득한 모든 증거물 선택할 수 있음. 버튼을 통해 6개씩 변경
        /// </summary>

        public void RenderEvidence()   // 증거선택 처음에 나오는 증거
        {
            //기존에 있던것 지우기 
            //evidenceObject.Clear();
            EAF = 0; //EvidenceArrFront

            j = 0;
            rightEnd = false;                 


            choiceEvidence1.SetActive(false);
            choiceEvidence2.SetActive(false);
            choiceEvidence1.GetComponent<Image>().sprite = null;
            choiceEvidence2.GetComponent<Image>().sprite = null;

            for (int i = 0; i < 6; i++)
            {
                evidenceObject[i].SetActive(false);
            }

            RenderText1();
            RenderText2();

            //evidenceObject[0].SetActive(true);
            //evidenceObject[1].SetActive(true);
            //evidenceObject[2].SetActive(true);
            //evidenceObject[3].SetActive(true);
            //evidenceObject[4].SetActive(true);
            //evidenceObject[5].SetActive(true);

            for (int num = 0; num < 6; num++)
            {
                if (DataManager.Instance.evidences.Count > num)
                {
                    evidenceObject[num].SetActive(true);
                    evidenceObject[num].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[num].Sprite);
                }
                else { break; }
            }

            //evidenceObject[0].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[0].Sprite);
            //evidenceObject[1].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[1].Sprite);
            //evidenceObject[2].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[2].Sprite);
            //evidenceObject[3].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[3].Sprite);
            //evidenceObject[4].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[4].Sprite);
            //evidenceObject[5].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[5].Sprite);
            //if (selectStrawCase == true) //딸기사건
            //{
            //    RenderText1();
            //    RenderText2();

            //    if (firstAskDone == false) //사고사/ 타살 증거
            //    {


            //        Debug.Log("딸기 사고/ 타살 증거 렌더");

            //        for (int i = 0; i < 6; i++)
            //        {

            //            for (int j = 0; j < DataManager.Instance.evidences.Count; j++)
            //            {
            //                if (DataManager.Instance.evidences[j].Sprite == DataManager.Instance.straw_CaseEvidence1[i])
            //                {
            //                    evidenceObject[i].SetActive(true);
            //                    evidenceObject[i].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.straw_CaseEvidence1[i]);
            //                }

            //            }

            //        }
            //    }
            //    else //범인 지목 증거 
            //    {

            //        Debug.Log("딸기범인지목 증거 렌더");
            //        for (int i = 0; i < 6; i++)
            //        {
            //            for (int j = 0; j < DataManager.Instance.evidences.Count; j++)
            //            {
            //                if (DataManager.Instance.evidences[j].Sprite == DataManager.Instance.straw_CaseEvidence2[i])
            //                {
            //                    evidenceObject[i].SetActive(true);
            //                    evidenceObject[i].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.straw_CaseEvidence2[i]);
            //                }

            //            }

            //        }
            //    }

            //}
            //else if (selectHoduCase == true)
            //{
            //    RenderText1();
            //    RenderText2();
            //   // Debug.Log("호두사건 클릭");

            //    if (firstAskDone == false) //사고사/ 타살 증거
            //    {
            //        //  firstAskDone = true;
            //        for (int i = 0; i < 6; i++)
            //        {
            //            for (int j = 0; j < DataManager.Instance.evidences.Count; j++)
            //            {
            //                if (DataManager.Instance.evidences[j].Sprite == DataManager.Instance.hodu_CaseEvidence1[i])
            //                {
            //                    evidenceObject[i].SetActive(true);
            //                    evidenceObject[i].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.hodu_CaseEvidence1[i]);
            //                }

            //            }

            //        }
            //    }
            //    else //범인 지목 증거 
            //    {
            //       //firstAskDone = false;
            //       // Debug.Log("호두범인지목 증거 렌더");
            //        for (int i = 0; i < 6; i++)
            //        {
            //            for (int j = 0; j < DataManager.Instance.evidences.Count; j++)
            //            {
            //                if (DataManager.Instance.evidences[j].Sprite == DataManager.Instance.hodu_CaseEvidence2[i])
            //                {
            //                    evidenceObject[i].SetActive(true);
            //                    evidenceObject[i].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.hodu_CaseEvidence2[i]);
            //                }

            //            }

            //        }
            //    }
            //}
            //else if (selectJellyJellyCase == true)
            //{
            //    RenderText1();
            //    RenderText2();

            //    if (firstAskDone == false) //사고사/ 타살 증거
            //    {
            //        for (int i = 0; i < 6; i++)
            //        {
            //            for (int j = 0; j < DataManager.Instance.evidences.Count; j++)
            //            {
            //                if (DataManager.Instance.evidences[j].Sprite == DataManager.Instance.jellyjelly_CaseEvidence1[i])
            //                {
            //                    evidenceObject[i].SetActive(true);
            //                    evidenceObject[i].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.jellyjelly_CaseEvidence1[i]);
            //                }

            //            }

            //        }
            //    }
            //    else //범인 지목 증거 
            //    {
            //        for (int i = 0; i < 6; i++)
            //        {
            //            for (int j = 0; j < DataManager.Instance.evidences.Count; j++)
            //            {
            //                if (DataManager.Instance.evidences[j].Sprite == DataManager.Instance.jellyjelly_CaseEvidence2[i])
            //                {
            //                    evidenceObject[i].SetActive(true);
            //                    evidenceObject[i].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.jellyjelly_CaseEvidence2[i]);
            //                }

            //            }

            //        }
            //    }
            //}

        }


        public void LeftButtonClickRenderEvidence() //왼쪽 버튼을 눌렀을 때 증거
        {
            Debug.Log(EAF);
            if (EAF == 0)
            {
                return;
            }
            else
            {
                //Debug.Log(" 왼쪽버튼 눌렀음! 누른거임! 눌렀다고! ");
                rightEnd = false;
                EAF = EAF - 6;
                evidenceObject[0].SetActive(true);
                evidenceObject[1].SetActive(true);
                evidenceObject[2].SetActive(true);
                evidenceObject[3].SetActive(true);
                evidenceObject[4].SetActive(true);
                evidenceObject[5].SetActive(true);

                evidenceObject[0].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[EAF].Sprite);
                evidenceObject[1].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[EAF + 1].Sprite);
                evidenceObject[2].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[EAF + 2].Sprite);
                evidenceObject[3].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[EAF + 3].Sprite);
                evidenceObject[4].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[EAF + 4].Sprite);
                evidenceObject[5].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[EAF + 5].Sprite);
            }
        }

        public void RightButtonClickRenderEvidence() //오른쪽 버튼을 눌렀을 때 증거 
        {
           // Debug.Log(EAF);
            if (DataManager.Instance.evidences.Count <= 6)
            {
                return;
            }
            else if (rightEnd == true) { return; }
            else
            {
                EAF = EAF + 6;
                j = 0;
                for (int i = EAF; i < EAF + 6; i++)
                {
                    if (i < DataManager.Instance.evidences.Count)
                    {
                        evidenceObject[j].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[i].Sprite);
                    }
                    else
                    {
                        for (int h = j; h < 6; h++)
                        {
                             evidenceObject[h].SetActive(false);
                            //evidenceObject[h].GetComponent<Image>().sprite = null;
                        }
                        rightEnd = true;
                        break;
                    }
                    j++;
                }
            }
        }


        public void RenderText1()
        {
            if (selectStrawCase == true)
            {
                if (firstAskDone == false) //사고사/ 타살 증거       
                {
                    textObject[0].GetComponent<Text>().text = DataManager.Instance.straw_CaseText1[text1];
                }
                else //범인지목
                {
                    textObject[0].GetComponent<Text>().text = DataManager.Instance.straw_CaseText11[text1];
                }
            }
            else if (selectHoduCase == true)
            {
                if (firstAskDone == false) //사고사/ 타살 증거
                {
                    textObject[0].GetComponent<Text>().text = DataManager.Instance.hodu_CaseText1[text1];
                }
                else //범인지목
                {
                    textObject[0].GetComponent<Text>().text = DataManager.Instance.hodu_CaseText11[text1];
                }
                
            }
            else if (selectJellyJellyCase == true)
            {
                if (firstAskDone == false) //사고사/ 타살 증거
                {
                    textObject[0].GetComponent<Text>().text = DataManager.Instance.jellyjelly_CaseText1[text1];
                }
                else //범인지목
                {
                    textObject[0].GetComponent<Text>().text = DataManager.Instance.jellyjelly_CaseText11[text1];
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
                //버튼 비활성화 
                strawButton.GetComponent<Button>().interactable = false;


            }
            else if (selectHoduCase == true)
            {
                hoduCaseActive = false;
                selectHoduCase = false;
                hoduIsActive.SetActive(true);
                //버튼 비활성화 
                hoduButton.GetComponent<Button>().interactable = false;


            }
            else if (selectJellyJellyCase==true)
            {
                jellyjellyCaseActive = false;
                selectJellyJellyCase = false;
                jellyjellyIsActive.SetActive(true);

                //버튼 비활성화 
                jellyjellyButton.GetComponent<Button>().interactable = false;
            }

        }
        public void RenderText2()
        {
            if (selectStrawCase == true)
            {
                if (firstAskDone == false) //사고사/ 타살 증거
                {
                    //if 사고사 / if 타살 
                    if (DataManager.Instance.isSuicide == false) // 사고사 이면
                    {
                        textObject[1].GetComponent<Text>().text = DataManager.Instance.Suicede_straw_CaseText2[text2];
                    }
                    else // 타살이면
                    {
                        textObject[1].GetComponent<Text>().text = DataManager.Instance.straw_CaseText2[text2];
                    }
                    //textObject[1].GetComponent<Text>().text = DataManager.Instance.straw_CaseText2[text2];
                    //Debug.Log(textObject[1].GetComponent<Text>().text);
                }
                else //범인지목
                {
                    textObject[1].GetComponent<Text>().text = DataManager.Instance.straw_CaseText22[text2];
                }
            }
            else if (selectHoduCase == true)
            {
                if (firstAskDone == false) //사고사/ 타살 증거
                {
                    //if 사고사 / if 타살 
                    if (DataManager.Instance.isSuicide == false) // 사고사 이면
                    {
                        textObject[1].GetComponent<Text>().text = DataManager.Instance.Suicede_hodu_CaseText2[text2];
                    }
                    else // 타살이면
                    {
                        textObject[1].GetComponent<Text>().text = DataManager.Instance.hodu_CaseText2[text2];
                    }
                   // textObject[1].GetComponent<Text>().text = DataManager.Instance.hodu_CaseText2[text2];
                }
                else //범인지목
                {
                    textObject[1].GetComponent<Text>().text = DataManager.Instance.hodu_CaseText22[text2];
                }
            }
            else if (selectJellyJellyCase == true)
            {
                if (firstAskDone == false) //사고사/ 타살 증거
                {
                    //if 사고사 / if 타살 
                    if (DataManager.Instance.isSuicide == false) // 사고사 이면
                    {
                        textObject[1].GetComponent<Text>().text = DataManager.Instance.Suicede_jellyjelly_CaseText2[text2];
                    }
                    else // 타살이면
                    {
                        textObject[1].GetComponent<Text>().text = DataManager.Instance.jellyjelly_CaseText2[text2];
                    }
                    //textObject[1].GetComponent<Text>().text = DataManager.Instance.jellyjelly_CaseText2[text2];
                }
                else //범인지목
                {
                    textObject[1].GetComponent<Text>().text = DataManager.Instance.jellyjelly_CaseText22[text2];
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

                //Debug.Log(dialogueName);
                if (dialogueName == "Kill_0_evidence_Handrail_evidence_Straw_Lid_1") //straw 타살 정답
                {
                    //Kill_0_난간의높이_딸기뚜껑_1
                    //증거선택 이후 범인지목 대화가 나와야함 
                    //범인 지목 대화가 나오도록 만들기 
                    GameModel.Instance.EventManager.AddBlockingEvent(new Call_criminalChoiceEvent("kill_straw_correctAnswer"));
                    firstAskDone = true;

                }
                else if (dialogueName == "Kill_0_evidence_Straw_Lid_evidence_Handrail_0") //straw 타살 정답
                {
                    //증거선택 이후 범인지목 대화가 나와야함 
                    //범인 지목 대화가 나오도록 만들기 
                    GameModel.Instance.EventManager.AddBlockingEvent(new Call_criminalChoiceEvent("kill_straw_correctAnswer"));
                    firstAskDone = true;
                }
                else if (dialogueName == "Kill_1_evidence_jellyjelly_pic_evidence_jelly_news_0") //straw 범인+증거 정답
                {
                    firstAskDone = false;
                    //범인 정답이면 그냥 텍스트 나오고 종료
                    CaseOff();
                    //strawCaseActive = false;
                    //selectStrawCase = false;
                    //strawIsActive.SetActive(true);

                    GameModel.Instance.EventManager.AddBlockingEvent(new CallAfterSuspectDialogueEvent("suspect_straw_correctAnswer"));
                    DataManager.Instance.happyEnding = true;
                    solveCase++;

                }
                else if (dialogueName == "Kill_1_evidence_jelly_news_evidence_jellyjelly_pic_0") //straw 범인+증거 정답
                {
                    firstAskDone = false;
                    //범인 정답이면 그냥 텍스트 나오고 끗 
                    CaseOff();
                    //strawCaseActive = false;
                    //selectStrawCase = false;
                    //strawIsActive.SetActive(true);
                    IsChoiceSuspect = false;
                    GameModel.Instance.EventManager.AddBlockingEvent(new CallAfterSuspectDialogueEvent("suspect_straw_correctAnswer"));
                    DataManager.Instance.happyEnding = true;
                    solveCase++;

                }
                else if (dialogueName == "Kill_0_evidence_freez_key_evidence_freezer_1") //hodu 타살 정답
                {
                    firstAskDone = true;
                    GameModel.Instance.EventManager.AddBlockingEvent(new Call_criminalChoiceEvent("kill_hodu_correctAnswer"));
                }
                else if (dialogueName == "Kill_0_evidence_freezer_evidence_freez_key_1")
                {
                    firstAskDone = true;
                    GameModel.Instance.EventManager.AddBlockingEvent(new Call_criminalChoiceEvent("kill_hodu_correctAnswer"));
                }
                else if (dialogueName == "Kill_1_evidence_ribontxt_evidence_NonePicture_1") //hodu 범인정답
                {
                    firstAskDone = false;
                    CaseOff();
                    //strawCaseActive = false;
                    //selectStrawCase = false;
                    //strawIsActive.SetActive(true);
                    IsChoiceSuspect = false;
                    GameModel.Instance.EventManager.AddBlockingEvent(new CallAfterSuspectDialogueEvent("suspect_hodu_correctAnswer"));
                    DataManager.Instance.happyEnding = true;
                    solveCase++;
                }
                else if (dialogueName == "Kill_1_evidence_NonePicture_evidence_ribontxt_1")
                {
                    firstAskDone = false;
                    CaseOff();
                    //strawCaseActive = false;
                    //selectStrawCase = false;
                    //strawIsActive.SetActive(true);
                    IsChoiceSuspect = false;
                    GameModel.Instance.EventManager.AddBlockingEvent(new CallAfterSuspectDialogueEvent("suspect_hodu_correctAnswer"));
                    DataManager.Instance.happyEnding = true;
                    solveCase++;
                }
                else if (dialogueName == "Kill_0_evidence_oven_evidence_choco_sighting_1") //jellyjelly 타살 정답
                {
                    firstAskDone = true;                  
                    GameModel.Instance.EventManager.AddBlockingEvent(new Call_criminalChoiceEvent("kill_jellyjelly_correctAnswer"));
                }
                else if (dialogueName == "Kill_0_evidence_choco_sighting_evidence_oven_0") //jellyjelly 타살 정답
                {
                    firstAskDone = true;
                    GameModel.Instance.EventManager.AddBlockingEvent(new Call_criminalChoiceEvent("kill_jellyjelly_correctAnswer"));
                }
                else if (dialogueName == "Kill_0_evidence_jelly_cos_evidence_jellyjellyDiary_1") //jellyjelly 범인정답
                {
                    firstAskDone = false;
                    CaseOff();
                    //strawCaseActive = false;
                    //selectStrawCase = false;
                    //strawIsActive.SetActive(true);
                    IsChoiceSuspect = false;
                    GameModel.Instance.EventManager.AddBlockingEvent(new CallAfterSuspectDialogueEvent("suspect_jellyjelly_correctAnswer"));
                    DataManager.Instance.happyEnding = true;
                    solveCase++;
                }
                else if (dialogueName == "Kill_0_evidence_jellyjellyDiary_evidence_jelly_cos_1") //jellyjelly 범인정답
                {
                    firstAskDone = false;
                    CaseOff();
                    //strawCaseActive = false;
                    //selectStrawCase = false;
                    //strawIsActive.SetActive(true);
                    IsChoiceSuspect = false;
                    GameModel.Instance.EventManager.AddBlockingEvent(new CallAfterSuspectDialogueEvent("suspect_jellyjelly_correctAnswer"));
                    DataManager.Instance.happyEnding = true;
                    solveCase++;
                }
                else // 타살 오답
                {
                    //firstAskDone = false;
                    Debug.Log(WrongAnswerNum);
                    Debug.Log("firstAskDone : " + firstAskDone);
                    if (WrongAnswerNum < 2)
                    {
                        //DataManager.Instance.Choice_StrawCase = true;

                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("Call_wrongAnswer"));

                        if (IsChoiceSuspect == false) //타살 증거선택 틀렸을 때 
                        {
                            EvidenceDiary.SetActive(true);
                            RenderEvidence();
                            RenderText1();
                            RenderText2();
                        }
                        else // 타살 범인 선택 틀렸을 때
                        {
                            //캐릭터마다 본인이 아니라는 대사 
                            //GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("Call_wrongAnswer"));
                            string name = "selectSuspect_"+selectSuspect;
                            Debug.Log(name);
                            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(name));
                            SuspectDiary.SetActive(true);
                        }
                        
                      
                        
                        WrongAnswerNum++;
                    }
                    else
                    {
                        CaseOff();
                        
                        //solveCase = 3;
                        solveFail = true;
                        firstAskDone = true;
                        DataManager.Instance.happyEnding = false;
                        EvidenceDiary.SetActive(false);
                        //LoadEnding();

                    }
                    

                }

            }
            else if(DataManager.Instance.isSuicide == false) //사고사
            {

                WrongAnswerNum++;
                if (WrongAnswerNum < 2)
                {
                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("사고사"));
                    //~~~사건은 사고/ 타살이다. 
                    if (selectStrawCase == true)
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new CallDialogueEvent("CallSceneStrawCase1"));
                    }
                    else if (selectHoduCase == true)
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new CallDialogueEvent("CallSceneHoduCase"));
                    }
                    else
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new CallDialogueEvent("CallSceneJellyjellyCase__"));
                    }
                    
                }
                else
                {
                     
                    CaseOff();

                    //배드엔딩 ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
                    GameModel.Instance.EffectManager.FadeIn();

                    SceneManager.UnloadSceneAsync("CallScene");
                    SceneManager.LoadScene("Ending", LoadSceneMode.Additive);
                    // ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

                    //solveCase = 3;
                    solveFail = false;
                    firstAskDone = true;
                    DataManager.Instance.happyEnding = false;
                    EvidenceDiary.SetActive(false);
                }
                //사고사는 아닌것같다.

            }
        }

    }
}
