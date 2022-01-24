using HappyBread.Core;
using HappyBread.ETC;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using HappyBread.GamePlay.GameState;

namespace HappyBread.GamePlay
{
    /// <summary>
    /// 증거를 저장하고 관리하는 클래스.
    /// </summary>
    public class CaseDiary : MonoBehaviour
    {
        public GameObject blankEvidenceObject;
        public GameObject content;
        //public GameObject cursorPrefab;
        public KeyCode NextCommand;
        
        private List<GameObject> evidencesObject = new List<GameObject>();   
        public List<GameObject> suspectsObject = new List<GameObject>();    // talkBoxCharacter 

        string characterFileName;

        //레이캐스트
        public Canvas RoomCanvas;    //raycast가 될 캔버스
        private GraphicRaycaster gr;
        private PointerEventData ped;
        GameObject obj;

        //대화 탭 키워드 선택
        public GameObject keywordTextView;
        public bool keywordTextViewBool = false; //대화 보는 창 
        public Text keywordTextViewText;

        public GameObject suspectsObj; 
        public GameObject detailObj;
        public bool detailObjSetactive = false; 
    

        //대화키워드 text 리스트 
        public List<Text> keyWordTextObj = new List<Text>();

        public Image detailImage;
        public Image detailText;


        //public int cursorIndex;
        //private int colNumber = 6;
        //public GameObject cursor;

        //evidenceWindow 확인을 위한 변수 
        public bool IsEvidenceWindow = false; // false : 증거화면 , true : 대화화면 

        //증거/대화들 false면 못찾아서 추가함
        public GameObject evidenceWindow;
        public GameObject talkBoxWindow;

        //대화 키워드 배경 
        public GameObject detailKeyword_bgi;


        public Vector2 NextMoveCommand { get; internal set; }

        public void AddEvidence(Evidence evidence)
        {
            //소리추가 
            GameModel.Instance.AudioManager.PlayEffectAudio("evidence");
            DataManager.Instance.evidences.Add(evidence);
            //최근습득증거 추가
            GameModel.Instance.latelyEvidence.latelyEvidenceTest();

        }

        public void DeleteEvidence(int index)
        {
            DataManager.Instance.evidences.RemoveAt(index);
        }

        public bool Contains(Evidence evidence)
        {
            return DataManager.Instance.evidences.Contains(evidence);
        }

        private void OnEnable()
        {
            //cursorIndex = 0;
            Render();
        }

        private void Render()  
        {
            // 기존 object를 삭제한다.
            //Destroy(cursor);
            //cursor = null;
            foreach (GameObject obj in evidencesObject)
            {
                Destroy(obj);
            }
            evidencesObject.Clear();

            // 저장된 배열을 토대로 새로 그린다. 
            foreach (Evidence evidence in DataManager.Instance.evidences)
            {
                GameObject newEvidenceObject = Instantiate<GameObject>(blankEvidenceObject, content.transform);
                newEvidenceObject.GetComponent<Image>().sprite = ResourceLoader.LoadSprite(evidence.Sprite);
                evidencesObject.Add(newEvidenceObject);
            }

            // 커서를 새로 그린다.
            //RenderCursor();
        }
        
        //public  void RenderCursor()
        //{
        //    if (IsEvidenceWindow == false) //증거탭 켜있는 상태 
        //    {
        //        if (evidencesObject.Count == 0) // 비어 있으면 아무 일도 일어나지 않는다.
        //        {
        //            return;
        //        }

        //        if (cursor == null) // 아직 생성되지 않았다면 생성한다.
        //        {
        //            cursor = Instantiate(cursorPrefab, evidencesObject[cursorIndex].transform);
        //        }

        //        if (cursorIndex < evidencesObject.Count)
        //        {
        //            cursor.transform.SetParent(evidencesObject[cursorIndex].transform);
        //            cursor.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        //        }

        //    }
        //    else if (IsEvidenceWindow == true && detailObjSetactive == false)//대화탭 켜있는 상태  
        //    {

        //        if (cursor == null) // 아직 생성되지 않았다면 생성한다.
        //        {
        //            cursor = Instantiate(cursorPrefab, suspectsObject[cursorIndex].transform);
        //        }

        //        if (cursorIndex < suspectsObject.Count)
        //        {
        //            cursor.transform.SetParent(suspectsObject[cursorIndex].transform);
        //            cursor.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        //        }
        //    } //210417 
        //    else if(detailObjSetactive == true) //디테일 ui 
        //    {
        //        if (cursor == null) // 아직 생성되지 않았다면 생성한다.
        //        {
        //            Debug.Log("커서 null");
        //            cursor = Instantiate(cursorPrefab, keyWordTextObj[cursorIndex].transform);
        //        }

        //        if (cursorIndex < keyWordTextObj.Count)
        //        {
        //            cursor.transform.SetParent(keyWordTextObj[cursorIndex].transform);
        //            cursor.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        //        }   
        //    }
            
        //}

        private void Update() 
        {

            if (NextCommand != KeyCode.None) 
            {
                // escape 눌렀을 때 를 Exit()로 옮겨야할듯 
                if (NextCommand == KeyCode.Escape) //esc 눌렀을 때  이 부분 x버튼 눌렀을 때도 적용해야함 
                {
                    //esc 상황마다 다른거 if문으로 만들기 
                    if (detailObjSetactive == false) // 다이어리 닫음 
                    {
                        Exit();
                    }
                    else if (detailObjSetactive == true && keywordTextViewBool == false) //detail 닫음 
                    {

                        detailObj.SetActive(false);
                        suspectsObj.SetActive(true);
                        detailObjSetactive = false; 

                        NextCommand = KeyCode.None;

                    }
                    else if (detailObjSetactive == true && keywordTextViewBool == true)
                    {
                        keywordTextView.SetActive(false);
                        keywordTextViewBool = false;
                        NextCommand = KeyCode.None;
                    }
                    
                }

                else if (NextCommand == GlobalGameData.mouseClick) //클릭했을 때 
                {
                    ped.position = Input.mousePosition;
                    List<RaycastResult> results = new List<RaycastResult>(); // 여기에 히트 된 개체 저장

                    gr.Raycast(ped, results);
                    obj = results[0].gameObject;


                    if (obj.CompareTag("Diary_evidence")) //증거 탭 증거 클릭
                    {
                            ShowEvidence();
                    }
                    else if (obj.CompareTag("Diary_tab_evidence")) //증거탭 클릭
                    {
                        //인물 탭 끄고 증거탭 켜기 
                        talkBoxWindow.SetActive(false);
                        evidenceWindow.SetActive(true);
                           
                       //IsEvidenceWindow = true;
                    }
                    else if (obj.CompareTag("Diary_tab_suspects")) // 증언 탭 클릭 
                    {
                        //증거 탭 끄고 인물탭 켜기
                        evidenceWindow.SetActive(false);
                        talkBoxWindow.SetActive(true);
                        

                    }
                    else if (obj.CompareTag("Diary_exit"))
                    {
                        ExitButton();
                    }
                    else
                    {
                            //이 외의 곳을 클릭했을 때는 별 일 음슴 
                    }

                    if (obj.CompareTag("Diary_suspects"))
                    {
                        //디테일 ui
                        MoveDetail();
                        detailObjSetactive = true;
                    }
                    else if (obj.CompareTag("Diary_detailText"))
                    {
                        string KeywordNum = obj.gameObject.name;
                        showDialogeText(KeywordNum);
                        keywordTextViewBool = true;
                    }
                    else 
                    {
                        Debug.Log("tag없음");
                    }
                }
                        
                    
                        
            }
                     

        }


        //private void ClickTab()
        //{
        //    if (IsEvidenceWindow == false) //true 이면 대화 화면 false이면 증거화면
        //    {
        //        //증거화면 끄고 대화화면 켜기 
        //        evidenceWindow.SetActive(false);
        //        talkBoxWindow.SetActive(true);
        //        IsEvidenceWindow = true;


        //    }
        //    else
        //    {
        //        //대화화면 끄고 증거화면 켜기
        //        talkBoxWindow.SetActive(false);
        //        evidenceWindow.SetActive(true);
        //        IsEvidenceWindow = false;
        //    }
        //}

        //2021 03 05 TalkBoxCusor를위해 수정 

        //public void MoveCursor()
        //{
        //    int row = cursorIndex / colNumber;
        //    int col = cursorIndex % colNumber;
        //    int maxRow = 0;
        //    int maxCol = 0;

        //    if(IsEvidenceWindow == false)// false : 증거화면
        //    {
        //         maxRow = (evidencesObject.Count - 1) / colNumber;
        //         maxCol = (evidencesObject.Count - 1) % colNumber;
        //    }
        //    else // true : talkBox
        //    {
        //         colNumber = 6;
        //         maxRow = (suspectsObject.Count - 1) / colNumber;
        //         maxCol = (suspectsObject.Count - 1) % colNumber;
        //         row = cursorIndex/ colNumber;
        //         col = cursorIndex% colNumber;

        //    }
            

        //    if (NextMoveCommand == Vector2.up)
        //    {
        //        if(row == 0)
        //        {
        //            if (col > maxCol)
        //            {
        //                row = maxRow - 1;
        //            }
        //            else
        //            {
        //                row = maxRow;
        //            }
        //        }
        //        else
        //        {
        //            row = row - 1;
        //        }
        //    }
        //    else if(NextMoveCommand == Vector2.down)
        //    {
        //        if (col > maxCol)
        //        {
        //            if (row == maxRow - 1)
        //            {
        //                row = 0;
        //            }
        //            else
        //            {
        //                row = row + 1;
        //            }
        //        }
        //        else
        //        {
        //            if (row == maxRow)
        //            {
        //                row = 0;
        //            }
        //            else
        //            {
        //                row = row + 1;   
        //            }
        //        }
        //    }
        //    else if (NextMoveCommand == Vector2.left)
        //    {
        //        if(col == 0)
        //        {
        //            if (row == maxRow)
        //            {
        //                col = maxCol;
        //            }
        //            else
        //            {
        //                col = colNumber - 1;
        //            }
        //        }
        //        else
        //        {
        //            col = col - 1;
        //        }
        //    }
        //    else if (NextMoveCommand == Vector2.right)
        //    {
        //        if(row == maxRow)
        //        {
        //            if (col == maxCol)
        //            {
        //                col = 0;
        //            }
        //            else
        //            {
        //                col += 1;
        //            }
        //        }
        //        else
        //        {
        //            if (col == colNumber - 1)
        //            {
        //                col = 0;
        //            }
        //            else
        //            {
        //                col += 1;
        //            }
        //        }
        //    }
        //    cursorIndex = row * colNumber + col;
        //    NextMoveCommand = Vector2.zero;
        //    RenderCursor();
        //}

        //detail 커서 움직임 
        //private void DetailMoveCursor()
        //{
        //    if (NextMoveCommand == Vector2.left)
        //    {
        //        if (cursorIndex == 0)
        //        {
        //            cursorIndex = 0;
        //        }
        //        else
        //        {
        //            cursorIndex = cursorIndex - 1;
        //        }

        //    }
        //    else if (NextMoveCommand == Vector2.right)
        //    {
        //        if (cursorIndex == keyWordTextObj.Count - 1)
        //        {
        //            cursorIndex = keyWordTextObj.Count - 1;
        //        }
        //        else
        //        {
        //            cursorIndex = cursorIndex + 1;
        //        }

        //    }

        //    NextMoveCommand = Vector2.zero;
        //    RenderCursor();
        //}

        private void ShowEvidence() // 증거탭 -> 증거 클릭 
        {
            //ped.position = Input.mousePosition;
            //List<RaycastResult> results = new List<RaycastResult>(); // 여기에 히트 된 개체 저장

            //gr.Raycast(ped, results);
            //GameObject obj = results[0].gameObject;

                 
                string name = obj.GetComponent<Image>().sprite.name;
                //리스트에서 이름을 찾자 

                for (int i=0; i< DataManager.Instance.evidences.Count; i++)
                {
                    if (DataManager.Instance.evidences[i].Sprite == name)
                    {
                       // DataManager.Instance.evidences[i].Action(); //
                       //GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(DataManager.Instance.evidences[i].Sprite));
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(name));
                    break;
                    }
                }
                                  
                Debug.Log(name);

            
            
            NextCommand = KeyCode.None;
        }



        //대화 탭 관련
        private void MoveDetail() // 대화 탭 -> 캐릭터 선택 
        {
            string name = obj.GetComponent<Image>().sprite.name;
            Debug.Log("디테일 대화 탭 -> 캐릭터 선택");
            //detailObjSetactive = true ; //나중에 끌 때 false으로 바꿔주기  

            detailObj.SetActive(true);
            NextCommand = KeyCode.None;

            //이미지 
            characterFileName = name;

            //Sprite detailImageSprite = ResourceLoader.LoadSprite(characterFileName);

            //detailImage.sprite = detailImageSprite;
            //설명text 이미지
            string characterDescription = name + "Description";
            Sprite detailTextImg = ResourceLoader.LoadSprite(characterDescription);
            //detailText.sprite = detailTextImg;


            //키워드들 채우기
            FillKeyword();


            //키워드 뒤에 이미지
            FillKeywordBGI();
            suspectsObj.SetActive(false);


        }

        private void FillKeywordBGI()
        {
            switch (characterFileName)
            {
                case "straw":
                    detailKeyword_bgi.GetComponent<Image>().sprite = ResourceLoader.LoadSprite("straw_keyword");
                    break;
                case "pancake":
                    detailKeyword_bgi.GetComponent<Image>().sprite = ResourceLoader.LoadSprite("pan_keyword");
                    break;
                case "crois":
                    detailKeyword_bgi.GetComponent<Image>().sprite = ResourceLoader.LoadSprite("cro_keyword");
                    break;
                case "maca":
                    detailKeyword_bgi.GetComponent<Image>().sprite = ResourceLoader.LoadSprite("maca_keyword");
                    break;
                case "jelly":
                    detailKeyword_bgi.GetComponent<Image>().sprite = ResourceLoader.LoadSprite("jelly_keyword");
                    break;
                case "jam":
                    detailKeyword_bgi.GetComponent<Image>().sprite = ResourceLoader.LoadSprite("penut_keyword");
                    break;
                case "hodu":
                    detailKeyword_bgi.GetComponent<Image>().sprite = ResourceLoader.LoadSprite("hodu_keyword");
                    break;
                case "donut":
                    detailKeyword_bgi.GetComponent<Image>().sprite = ResourceLoader.LoadSprite("donut_keyword");
                    break;
                case "twist":
                    detailKeyword_bgi.GetComponent<Image>().sprite = ResourceLoader.LoadSprite("kwabakki_keyword");
                    break;
                case "choco":
                    detailKeyword_bgi.GetComponent<Image>().sprite = ResourceLoader.LoadSprite("sora_keyword");
                    break;
                case "cake":
                    //cup_keyword
                    detailKeyword_bgi.GetComponent<Image>().sprite = ResourceLoader.LoadSprite("cup_keyword");

                    break;

            }
        }
        private void FillKeyword()
        {

            for (int i = 0; i < keyWordTextObj.Count; i++)
            {
                switch (characterFileName)
                {
                    case "straw":                                            
                        //if strawDialogeKeywordsOpen[i] ==1 이면 else 넘어가기 
                        if (DataManager.Instance.straw_DialogeKeywordsOpen[i] == true)
                        {
                            keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.strawDialogeKeywords[i];
                        }
                        else
                        {
                            keyWordTextObj[i].text = " ";
                        }
                        Debug.Log("딸기 키워드?????");
                        break;
                    case "pancake":
                        if (DataManager.Instance.pancake_DialogeKeywordsOpen[i] == true)
                        {
                            keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.pancakeDialogeKeywords[i];
                        }
                        else
                        {
                            keyWordTextObj[i].text = " ";
                        }
                        Debug.Log("팬케이크 키워드");
                        break;

                    case "crois":
                        if (DataManager.Instance.crois_DialogeKeywordsOpen[i] == true)
                        {
                            keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.croisDialogeKeywords[i];
                        }
                        else
                        {
                            keyWordTextObj[i].text = " ";
                        }
                        Debug.Log("크로아상 키워드");
                        break;

                    case "maca":
                        if (DataManager.Instance.maca_DialogeKeywordsOpen[i] == true)
                        {
                            keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.macaDialogeKeywords[i];
                        }
                        else
                        {
                            keyWordTextObj[i].text = " ";
                        }
                        Debug.Log("마카롱 키워드");
                        break;
                    case "jelly":
                        if (DataManager.Instance.jelly_DialogeKeywordsOpen[i] == true)
                        {
                            keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.jellyDialogeKeywords[i];
                        }
                        else
                        {
                            keyWordTextObj[i].text = " ";
                        }
                        Debug.Log("젤리 키워드");
                        break;
                    case "jam":
                        if (DataManager.Instance.jam_DialogeKeywordsOpen[i] == true)
                        {
                            keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.jamDialogeKeywords[i];
                        }
                        else
                        {
                            keyWordTextObj[i].text = " ";
                        }
                        Debug.Log("잼 키워드");
                        break;

                    case "hodu":
                        if (DataManager.Instance.hodu_DialogeKeywordsOpen[i] == true)
                        {
                            keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.hoduDialogeKeywords[i];
                        }
                        else
                        {
                            keyWordTextObj[i].text = " ";
                        }
                        Debug.Log("호두 키워드");
                        break;

                    case "donut":
                        if (DataManager.Instance.donut_DialogeKeywordsOpen[i] == true)
                        {
                            keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.donutDialogeKeywords[i];
                        }
                        else
                        {
                            keyWordTextObj[i].text = " ";
                        }
                        Debug.Log("도넛 키워드?");
                        break;
                    case "twist":
                        if (DataManager.Instance.twist_DialogeKeywordsOpen[i] == true)
                        {
                            keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.twistDialogeKeywords[i];
                        }
                        else
                        {
                            keyWordTextObj[i].text = " ";
                        }
                        break;
                    case "choco":
                        if (DataManager.Instance.choco_DialogeKeywordsOpen[i] == true)
                        {
                            keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.chocoDialogeKeywords[i];
                        }
                        else
                        {
                            keyWordTextObj[i].text = " ";
                        }
                        break;
                    default:
                        break;


                }

            }
        }
        //대화탭 -> 캐릭터 선택 -> 캐릭터 대화 정보 창에서 스페이스바를 누르면 해당 대화를 보여준다. 
        private void showDialogeText(string num)
        {
            //대화 ui 외에 전부 false 
            //index랑 대화랑 매칭  

            switch (characterFileName)
            {
                case "straw":
                    //if strawDialogeKeywordsOpen[i] ==1 이면 else 넘어가기 
                    if (num == "0") //0번 키워드 일 때
                    {
                        //해당 키워드 대화 이벤트 
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day1_straw_1"));
                    }
                    else if (num == "1")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day1_straw_2"));
                    }


                    Debug.Log("딸기 키워드 클릭");
                    break;
                case "pancake":
                    if (num == "0")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day1_pancake_1"));
                    }
                    else if (num == "1")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day2_pancke_1"));
                    }
                    else if (num == "2")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day3_pancake_1"));
                    }

                    Debug.Log("팬케이크 키워드 클릭");
                    break;

                case "crois":
                    //if (DataManager.Instance.crois_DialogeKeywordsOpen[i] == true)
                    //{
                    //    keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.croisDialogeKeywords[i];
                    //}
                    //else
                    //{
                    //    keyWordTextObj[i].text = "?";
                    //}
                    //Debug.Log("크로아상 키워드");
                    break;

                case "maca":
                    if (num == "0")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day2_maca_1"));
                    }
                    else if (num == "1")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day1_maca_2"));
                    }
                    else if (num == "2")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day3_maca_1"));
                    }
                    else if (num == "3")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day4_maca_1"));
                    }
                    Debug.Log("마카롱 키워드 클릭");
                    break;
                case "jelly":
                    if (num == "0")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day1_jelly_1"));
                    }
                    else if (num == "1")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day2_jelly_1"));
                    }
                    else if (num == "2")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day2_jelly_3"));
                    }
                    else if (num == "3")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day4_jelly_1"));
                    }
                    Debug.Log("젤리 키워드 클릭");
                    break;
                case "jam":
                    if (num=="0")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day1_jam_2"));
                    }
                    else if(num=="1")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day2_jam_1"));
                    }
                    else if (num == "2")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day3_jam_1"));
                    }
                    else if (num == "3")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day3_jam_1"));
                    }
                    Debug.Log("잼 키워드");
                    break;

                case "hodu":
                    if (num == "0")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day1_hodu_1"));
                    }
                    else if(num=="1")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day2_hodu_1"));
                    }
                    Debug.Log("호두 키워드");
                    break;

                case "donut":
                    if (num=="0")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day3_donut_1"));
                    }

                    Debug.Log("도넛 키워드?");
                    break;
                case "twist":
                    if (num=="0")
                    {
                         GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day1_twist_1"));
                    }              
                    else if(num=="1")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day1_twist_2"));
                    }
                    else if (num == "2")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day1_twist_3"));
                    }
                    else if (num == "3")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day2_twist_1"));
                    }
                    else if (num == "4")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day4_twist_1"));
                    }
                    break;
                case "choco":
                    if (num == "0")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day1_choco_3"));
                    }
                    else if (num == "1")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day2_choco_2"));
                    }
                    else if (num == "2")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day2_choco_3"));
                    }
                    else if (num == "3")
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day3_choco_1"));
                    }

                    break;
                default:
                    break;
            }


        }
        private void Exit()
        {
            //GameModel.Instance.StateManager.UndoState();
            GameModel.Instance.StateManager.ChangeState(new PlayingState());
            NextCommand = KeyCode.None;
            gameObject.SetActive(false);
        }

        private void ExitButton()
        {
            //esc 상황마다 다른거 if문으로 만들기 
            if (detailObjSetactive == false) // 다이어리 닫음 
            {
                Exit();
            }
            else if (detailObjSetactive == true && keywordTextViewBool == false) //detail 닫음 
            {

                detailObj.SetActive(false);
                suspectsObj.SetActive(true);
                detailObjSetactive = false;

                NextCommand = KeyCode.None;

            }
            else if (detailObjSetactive == true && keywordTextViewBool == true)
            {
                keywordTextView.SetActive(false);
                keywordTextViewBool = false;
                NextCommand = KeyCode.None;
            }
        }

        private void Awake()
        {
            gr = RoomCanvas.GetComponent<GraphicRaycaster>();
            ped = new PointerEventData(null);
        }
    }

}