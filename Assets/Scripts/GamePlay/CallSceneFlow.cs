using HappyBread.Core;
using HappyBread.ETC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace HappyBread.GamePlay
{
    public class CallSceneFlow : MonoBehaviour
    {
        ///<summary>
        ///추리하기 플로우를 관리하는 클래스 (은실 수정 — 2022.01.21.)
        ///<summary>
        ///

        public GameObject chooseCase;

        public GameObject cursorPrefab; //번인지목 커서
        public GameObject cursor;

        public GameObject clickButtonObject;

        //레이캐스트
        //public Canvas CallCanvas;    //raycast가 될 캔버스
        //private GraphicRaycaster gr;
        //private PointerEventData ped;
        //GameObject obj;

        private string spriteName;

        //현재 진행중인 캐릭터 이름  
        private string characterName;

        public KeyCode NextCommand;
        // Start is called before the first frame update
        void Start()
        {
            GameModel.Instance.UIManager.BasicUIHide(); //불필요한 ui숨김

            //gr = CallCanvas.GetComponent<GraphicRaycaster>();
            //ped = new PointerEventData(null);

        }

        // Update is called once per frame
        void Update()
        {
            if (DataManager.Instance.Call_NextCommand != KeyCode.None)
            {
                if (DataManager.Instance.Call_NextCommand == GlobalGameData.mouseClick)
                {
                    GameObject clickButtonObject = EventSystem.current.currentSelectedGameObject;

                    //mouseClick();
                }
            }
            if (CallManager.Instance.solveFail == true)
            {
                GameModel.Instance.EffectManager.FadeIn();

                SceneManager.UnloadSceneAsync("CallScene");
                SceneManager.LoadScene("Ending", LoadSceneMode.Additive);

            }
            //if (CallManager.Instance.solveCase == 3) //모든사건을 해결하면
            //{
                
            //    GameModel.Instance.EffectManager.FadeIn();

            //    SceneManager.UnloadSceneAsync("CallScene");

            //    SceneManager.LoadScene("Ending", LoadSceneMode.Additive);

            //    //엔딩state
            //}
        }

        public void solveCaseALL()
        {
                GameModel.Instance.EffectManager.FadeIn();

                SceneManager.UnloadSceneAsync("CallScene");
                SceneManager.LoadScene("Ending", LoadSceneMode.Additive);

                //엔딩state
        }

        //증거선택 버튼 누름
        public void ClickEvidenceButton()
        {
            GameObject clickButtonObject = EventSystem.current.currentSelectedGameObject;

            Debug.Log(CallManager.Instance.selectStrawCase);
            if (clickButtonObject.CompareTag("Call_choiceEvidence")) //증거클릭
            {
                if (CallManager.Instance.evidenceBox1 == true) //첫번째 증거 선택 
                {
                    spriteName = clickButtonObject.GetComponent<Image>().sprite.name;
                    CallManager.Instance.choiceEvidence1.GetComponent<Image>().sprite = ResourceLoader.LoadSprite(spriteName);
                    CallManager.Instance.choiceEvidence1.SetActive(true);

                    CallManager.Instance.selectEvidence1 = spriteName;

                    CallManager.Instance.evidenceBox1 = false;
                    CallManager.Instance.evidenceBoxObj1.SetActive(false);

                    DataManager.Instance.Call_NextCommand = KeyCode.None;
                }
                else if (CallManager.Instance.evidenceBox2 == true)  //두번째 증거 선택
                {
                    spriteName = clickButtonObject.GetComponent<Image>().sprite.name;
                    CallManager.Instance.choiceEvidence2.GetComponent<Image>().sprite = ResourceLoader.LoadSprite(spriteName);
                    CallManager.Instance.choiceEvidence2.SetActive(true);

                    CallManager.Instance.selectEvidence2 = spriteName;

                    CallManager.Instance.evidenceBox2 = false;
                    CallManager.Instance.evidenceBoxObj2.SetActive(false);

                    DataManager.Instance.Call_NextCommand = KeyCode.None;
                }
            }
        }

        public void mouseClick_strawCase()
        {
            Debug.Log("딸기 케이스 클릭함");
           

            CallManager.Instance.strawCaseClick();
            DataManager.Instance.Call_NextCommand = KeyCode.None;
        }

        public void mouseClick_hoduCase()
        {
            Debug.Log("호두케이스 선택함");
            CallManager.Instance.hoduCaseClick();
            DataManager.Instance.Call_NextCommand = KeyCode.None;
        }

        public void mouseClick_jellyjellyCase()
        {
            Debug.Log("젤리젤리케이스 선택함");
            CallManager.Instance.jellyjellyCaseClick();
            DataManager.Instance.Call_NextCommand = KeyCode.None;
        }

        public void text1_left_button()
        {
            Debug.Log("왼쪽 버튼 누름");
            if (CallManager.Instance.text1 == 0) { CallManager.Instance.text1 = 1; }
            else { CallManager.Instance.text1 = CallManager.Instance.text1 - 1; }

            CallManager.Instance.RenderText1();
        }

        public void text1_right_button()
        {
            if (CallManager.Instance.text1 == 1) { CallManager.Instance.text1 = 0; }
            else { CallManager.Instance.text1 = CallManager.Instance.text1 + 1; }
            Debug.Log("오른쪾버튼 누름");
            CallManager.Instance.RenderText1();
        }

        public void text2_left_button()
        {
            if (CallManager.Instance.text2 == 0) { CallManager.Instance.text2 = 1; }
            else { CallManager.Instance.text2 = CallManager.Instance.text2 - 1; }

            CallManager.Instance.RenderText2();
        }

        public void text2_right_button()
        {
            if (CallManager.Instance.text2 == 1) { CallManager.Instance.text2 = 0; }
            else { CallManager.Instance.text2 = CallManager.Instance.text2 + 1; }

            CallManager.Instance.RenderText2();
        }

        public void Call_OK_Button()
        {
            //CallManager.Instance.firstAskDone = true;
            //선택한 증거에 대한 대화 
            if (DataManager.Instance.isSuicide == true) //타살 
            {
                //범인까지 지목하는 플로우의 대화 가져오기

                CallManager.Instance.EvidenceDiary.SetActive(false);
                CallManager.Instance.OkBtnDialogue();

                DataManager.Instance.Call_NextCommand = KeyCode.None;
            }
            else
            {
                //케이스 다시 고르기

                CallManager.Instance.EvidenceDiary.SetActive(false);
                CallManager.Instance.OkBtnDialogue();

                DataManager.Instance.Call_NextCommand = KeyCode.None;
            }
        }

        public void selectEvidenceBox1()
        {
            //증거1 박스 선택 
            if (CallManager.Instance.evidenceBox2 == true)
            {
                DataManager.Instance.Call_NextCommand = KeyCode.None;
            }
            else
            {
                //여기 고치면 될듯
                CallManager.Instance.evidenceBox1 = true; //이거true false도 봐야함 
                CallManager.Instance.evidenceBoxObj1.SetActive(true);

                DataManager.Instance.Call_NextCommand = KeyCode.None;
            }
        }

        public void selectEvidenceBox2()
        {
            //증거2 박스 선택 
            if (CallManager.Instance.evidenceBox1 == true)
            {
                DataManager.Instance.Call_NextCommand = KeyCode.None;
            }
            else
            {
                CallManager.Instance.evidenceBox2 = true;
                CallManager.Instance.evidenceBoxObj2.SetActive(true);

                DataManager.Instance.Call_NextCommand = KeyCode.None;
            }
        }

        public void selectSuspect()
        {
            clickButtonObject = EventSystem.current.currentSelectedGameObject;
            spriteName = clickButtonObject.GetComponent<Image>().sprite.name;
            if (spriteName == "유저액자")
            {

                GameModel.Instance.MiddleEnding.incompetentEnding();

            }
            else
            {            
                CallManager.Instance.selectSuspect = spriteName;

                ok_suspect();
            }

            DataManager.Instance.Call_NextCommand = KeyCode.None;
        }

        public void ok_suspect()
        {
            //커서 지우기 
            Destroy(cursor);
            //지목 창 지우기 
            CallManager.Instance.SuspectDiary.SetActive(false);

            CallManager.Instance.IsChoiceSuspect = true; 

            //캐릭터 마다 다르게 하기 
            GameModel.Instance.EventManager.AddBlockingEvent(new CallDialogueEvent("Call_chiceSuspect"));
            DataManager.Instance.Call_NextCommand = KeyCode.None;



        }


        private void mouseClick()
        {
            Debug.Log(CallManager.Instance.selectStrawCase);
            if (clickButtonObject.CompareTag("Call_choiceEvidence")) //증거클릭
            {
                //if (CallManager.Instance.evidenceBox1 == true) //첫번째 증거 선택 
                //{
                //    spriteName = clickButtonObject.GetComponent<Image>().sprite.name;
                //    CallManager.Instance.choiceEvidence1.GetComponent<Image>().sprite = ResourceLoader.LoadSprite(spriteName);
                //    CallManager.Instance.choiceEvidence1.SetActive(true);

                //    CallManager.Instance.selectEvidence1 = spriteName;

                //    CallManager.Instance.evidenceBox1 = false;
                //    CallManager.Instance.evidenceBoxObj1.SetActive(false);

                //    DataManager.Instance.Call_NextCommand = KeyCode.None;
                //}
                //else if (CallManager.Instance.evidenceBox2 == true)  //두번째 증거 선택
                //{
                //    spriteName = clickButtonObject.GetComponent<Image>().sprite.name;
                //    CallManager.Instance.choiceEvidence2.GetComponent<Image>().sprite = ResourceLoader.LoadSprite(spriteName);
                //    CallManager.Instance.choiceEvidence2.SetActive(true);

                //    CallManager.Instance.selectEvidence2 = spriteName;

                //    CallManager.Instance.evidenceBox2 = false;
                //    CallManager.Instance.evidenceBoxObj2.SetActive(false);

                //    DataManager.Instance.Call_NextCommand = KeyCode.None;
                //}

                //// DataManager.Instance.Call_NextCommand = KeyCode.None;
            }
            else if (clickButtonObject.CompareTag("Call_StrawCaseButton")) //strawCase클릭
            {
                //Debug.Log("딸기 케이스 클릭함");
                //CallManager.Instance.strawCaseClick();
                //DataManager.Instance.Call_NextCommand = KeyCode.None;


            }
            else if (clickButtonObject.CompareTag("Call_HoduCaseButton")) //호두케이스 클릭
            {
                //Debug.Log("호두케이스 선택함");
                //CallManager.Instance.hoduCaseClick();
                //DataManager.Instance.Call_NextCommand = KeyCode.None;
            }
            else if (clickButtonObject.CompareTag("Call_JellyJellyCaseButton")) //젤리젤리케이스 클릭
            {
                //Debug.Log("젤리젤리케이스 선택함");
                //CallManager.Instance.jellyjellyCaseClick();
                //DataManager.Instance.Call_NextCommand = KeyCode.None;
            }
            else if (clickButtonObject.CompareTag("Call_Text1_leftButton")) //text1 왼쪽 버튼
            {
                //Debug.Log("왼쪽 버튼 누름");
                //if (CallManager.Instance.text1 == 0) { CallManager.Instance.text1 = 1; }
                //else { CallManager.Instance.text1 = CallManager.Instance.text1 - 1; }

                //CallManager.Instance.RenderText1();
            }
            else if (clickButtonObject.CompareTag("Call_Text1_rightButton")) //text1 오른쪽 버튼
            {
                //if (CallManager.Instance.text1 == 1) { CallManager.Instance.text1 = 0; }
                //else { CallManager.Instance.text1 = CallManager.Instance.text1 + 1; }

                //CallManager.Instance.RenderText1();
            }
            else if (clickButtonObject.CompareTag("Call_Text2_leftButton")) //text2 왼쪽 버튼
            {
                //if (CallManager.Instance.text2 == 0) { CallManager.Instance.text2 = 1; }
                //else { CallManager.Instance.text2 = CallManager.Instance.text2 - 1; }

                //CallManager.Instance.RenderText2();
            }
            else if (clickButtonObject.CompareTag("Call_Text2_rightButton "))  //text2 오른쪽 버튼
            {
                //if (CallManager.Instance.text2 == 1) { CallManager.Instance.text2 = 0; }
                //else { CallManager.Instance.text2 = CallManager.Instance.text2 + 1; }

                //CallManager.Instance.RenderText2();
            }
            else if (clickButtonObject.CompareTag("Call_okButton"))   //확인버튼
            {
                //CallManager.Instance.firstAskDone = true;
                //선택한 증거에 대한 대화 
                //if (DataManager.Instance.isSuicide == true) //타살 
                //{
                //    //범인까지 지목하는 플로우의 대화 가져오기
                //    Debug.Log("타살을 누른 상태에서 ok누름");

                //    CallManager.Instance.EvidenceDiary.SetActive(false);
                //    CallManager.Instance.OkBtnDialogue();

                //    DataManager.Instance.Call_NextCommand = KeyCode.None;
                //}
                //else
                //{
                //    Debug.Log("사고사를 누른 상태에서 ok누름");
                //    //평범한 대화 불러오기

                //    //선택한 케이스 off
                //    CallManager.Instance.CaseOff();


                //    CallManager.Instance.EvidenceDiary.SetActive(false);
                //    CallManager.Instance.OkBtnDialogue();

                //    DataManager.Instance.Call_NextCommand = KeyCode.None;
                //}

            }
            else if (clickButtonObject.CompareTag("Call_slectEvidenceBox1"))
            {
                //증거1 박스 선택 
                //if (CallManager.Instance.evidenceBox2 == true)
                //{
                //    Debug.Log("두번째 증거를 먼저 골라주세요");
                //    DataManager.Instance.Call_NextCommand = KeyCode.None;
                //}
                //else
                //{
                //    //여기 고치면 될듯
                //    CallManager.Instance.evidenceBox1 = true; //이거true false도 봐야함 
                //    CallManager.Instance.evidenceBoxObj1.SetActive(true);

                //    DataManager.Instance.Call_NextCommand = KeyCode.None;
                //}
            }
            else if (clickButtonObject.CompareTag("Call_slectEvidenceBox2"))
            {
                //증거2 박스 선택 
                //if (CallManager.Instance.evidenceBox1 == true)
                //{
                //    Debug.Log("첫번째 증거를 먼저 골라주세요");
                //    DataManager.Instance.Call_NextCommand = KeyCode.None;
                //}
                //else
                //{
                //    CallManager.Instance.evidenceBox2 = true;
                //    CallManager.Instance.evidenceBoxObj2.SetActive(true);

                //    DataManager.Instance.Call_NextCommand = KeyCode.None;
                //}
            }
            else if (clickButtonObject.CompareTag("Call_slectSuspect"))//증인 선택
            {

                //spriteName = clickButtonObject.GetComponent<Image>().sprite.name;
                //CallManager.Instance.selectSuspect = spriteName;
                ////마우스로 위치 받아와서 위에 커서 같은거 올리기 

                //if (cursor != null)
                //{
                //    Destroy(cursor);
                //    cursor = null;
                //    renderCursor();
                //}
                //else
                //{
                //    renderCursor();
                //}
                

                //DataManager.Instance.Call_NextCommand = KeyCode.None;
            }
            else if (clickButtonObject.CompareTag("Call_ok_suspect")) //범인 지목 후 ok버튼 누름 
            {
                ////커서 지우기 
                //Destroy(cursor);
                ////지목 창 지우기 
                //CallManager.Instance.SuspectDiary.SetActive(false);

                //GameModel.Instance.EventManager.AddBlockingEvent(new CallDialogueEvent("Call_chiceSuspect"));
                //DataManager.Instance.Call_NextCommand = KeyCode.None;

                
            }
            else
            {
                //if (CallManager.Instance.stratImage == true)
                //{
                //    CallManager.Instance.startImage.SetActive(false);
                //    CallManager.Instance.stratImage = false;
                //    chooseCase.SetActive(true);

                //}
            }
            
        }
        private void renderCursor()
        {
            cursor = Instantiate(cursorPrefab, clickButtonObject.transform);
        }
        
    }
}