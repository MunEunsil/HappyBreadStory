using HappyBread.Core;
using HappyBread.ETC;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



namespace HappyBread.GamePlay
{
    /// <summary>
    /// 증거를 저장하고 관리하는 클래스.
    /// </summary>
    public class CaseDiary : MonoBehaviour
    {
        public GameObject blankEvidenceObject;
        public GameObject content;
        public GameObject cursorPrefab;
        public KeyCode NextCommand;
        //public List<Evidence> evidences = new List<Evidence>();
        private List<GameObject> evidencesObject = new List<GameObject>();   
        public List<GameObject> suspectsObject = new List<GameObject>();    // talkBoxCharacter 

        string characterFileName;


        //키워드를 선택하면 키워드에 해당하는 텍스트no
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


        public int cursorIndex;
        private int colNumber = 6;
        public GameObject cursor;

        //evidenceWindow 확인을 위한 변수 
        public bool IsEvidenceWindow = false; // false : 증거화면 , true : 대화화면 

        //증거/대화들 false면 못찾아서 추가함
        public GameObject evidenceWindow;
        public GameObject talkBoxWindow;

     


        public Vector2 NextMoveCommand { get; internal set; }

        public void AddEvidence(Evidence evidence)
        {
           DataManager.Instance.evidences.Add(evidence);
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
            cursorIndex = 0;
            Render();
        }

        private void Render()  
        {
            // 기존 object를 삭제한다.
            Destroy(cursor);
            cursor = null;
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
            RenderCursor();
        }
        
        public  void RenderCursor()
        {
            if (IsEvidenceWindow == false) //증거탭 켜있는 상태 
            {
                if (evidencesObject.Count == 0) // 비어 있으면 아무 일도 일어나지 않는다.
                {
                    return;
                }

                if (cursor == null) // 아직 생성되지 않았다면 생성한다.
                {
                    cursor = Instantiate(cursorPrefab, evidencesObject[cursorIndex].transform);
                }

                if (cursorIndex < evidencesObject.Count)
                {
                    cursor.transform.SetParent(evidencesObject[cursorIndex].transform);
                    cursor.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                }

            }
            else if (IsEvidenceWindow == true && detailObjSetactive == false)//대화탭 켜있는 상태  
            {

                if (cursor == null) // 아직 생성되지 않았다면 생성한다.
                {
                    cursor = Instantiate(cursorPrefab, suspectsObject[cursorIndex].transform);
                }

                if (cursorIndex < suspectsObject.Count)
                {
                    cursor.transform.SetParent(suspectsObject[cursorIndex].transform);
                    cursor.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                }
            } //210417 
            else if(detailObjSetactive == true) //디테일 ui 
            {
                if (cursor == null) // 아직 생성되지 않았다면 생성한다.
                {
                    Debug.Log("커서 null");
                    cursor = Instantiate(cursorPrefab, keyWordTextObj[cursorIndex].transform);
                }

                if (cursorIndex < keyWordTextObj.Count)
                {
                    cursor.transform.SetParent(keyWordTextObj[cursorIndex].transform);
                    cursor.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                }   
            }
            
        }

        private void Update() 
        {
            if (detailObjSetactive == false)   // 디테일UI 꺼져있는 경우(인물만 나와있는 ui)
            {
                // 방향키를 누르는 경우
                if (NextMoveCommand != Vector2.zero)
                {
                    MoveCursor();
                }
            }
            else if (detailObjSetactive == true) //디테일UI 켜져있는 경우 (대화 키워드가 있는 ui)
            {
                if (NextMoveCommand != Vector2.zero)
                {
                    DetailMoveCursor();
                }
                   
            }

            if (NextCommand != KeyCode.None) 
            {
                if (NextCommand == KeyCode.Escape) //esc 눌렀을 때
                {
                    //esc 상황마다 다른거 if문으로 만들기 
                    if (detailObjSetactive == false) // 다이어리 닫음
                    {
                        Exit();
                    }
                    else if (detailObjSetactive == true && keywordTextViewBool == false) //detail 닫음 
                    {
                        cursorIndex = 0;
                        Destroy(cursor);
                        cursor = null;

                        detailObj.SetActive(false);
                        suspectsObj.SetActive(true);
                        detailObjSetactive = false; 

                        NextCommand = KeyCode.None;


                        RenderCursor();

                    }
                    else if (detailObjSetactive == true && keywordTextViewBool == true)
                    {
                        cursorIndex = 0;
                        Destroy(cursor);
                        cursor = null;

                        keywordTextView.SetActive(false);
                        keywordTextViewBool = false;
                        NextCommand = KeyCode.None;

                        RenderCursor();
                    }
                    
                }
                else if (NextCommand == KeyCode.Space) //space 눌렀을 때
                {
                    // Debug.Log("스페이스바 누름");

                    if (IsEvidenceWindow == false) //증거탭
                    {
                        ShowEvidence();
                    }
                    else if (IsEvidenceWindow == true && detailObjSetactive == false)//대화 탭
                    {   //디테일 ui 
                        MoveDetail(); 
                    }
                    else if (detailObjSetactive == true)
                    {
                        // 디테일 켜져있을때 스페이스바를 누르면 일어날 일을 여기에 만들면 됨 
                        showDialogeText();
                    }
                        
                }
                else if (NextCommand ==KeyCode.Tab) // tab 눌렀을 때
                {
                    cursorIndex = 0;
                    Destroy(cursor);
                    cursor = null;
                
                    // Debug.Log("tab 눌렀음!");
                    if (IsEvidenceWindow == false) //true 이면 대화 화면 false이면 증거화면
                    {
                        //증거화면 끄고 대화화면 켜기 
                        evidenceWindow.SetActive(false);
                        talkBoxWindow.SetActive(true);
                        IsEvidenceWindow = true;


                    }
                    else
                    {
                        //대화화면 끄고 증거화면 켜기
                        talkBoxWindow.SetActive(false);
                        evidenceWindow.SetActive(true);
                        IsEvidenceWindow =false;
                    }

                    RenderCursor();
                }
            }
                     

        }

        //2021 03 05 TalkBoxCusor를위해 수정 

        public void MoveCursor()
        {
            int row = cursorIndex / colNumber;
            int col = cursorIndex % colNumber;
            int maxRow = 0;
            int maxCol = 0;

            if(IsEvidenceWindow == false)// false : 증거화면
            {
                 maxRow = (evidencesObject.Count - 1) / colNumber;
                 maxCol = (evidencesObject.Count - 1) % colNumber;
            }
            else // true : talkBox
            {
                 colNumber = 6;
                 maxRow = (suspectsObject.Count - 1) / colNumber;
                 maxCol = (suspectsObject.Count - 1) % colNumber;
                 row = cursorIndex/ colNumber;
                 col = cursorIndex% colNumber;

            }
            

            if (NextMoveCommand == Vector2.up)
            {
                if(row == 0)
                {
                    if (col > maxCol)
                    {
                        row = maxRow - 1;
                    }
                    else
                    {
                        row = maxRow;
                    }
                }
                else
                {
                    row = row - 1;
                }
            }
            else if(NextMoveCommand == Vector2.down)
            {
                if (col > maxCol)
                {
                    if (row == maxRow - 1)
                    {
                        row = 0;
                    }
                    else
                    {
                        row = row + 1;
                    }
                }
                else
                {
                    if (row == maxRow)
                    {
                        row = 0;
                    }
                    else
                    {
                        row = row + 1;   
                    }
                }
            }
            else if (NextMoveCommand == Vector2.left)
            {
                if(col == 0)
                {
                    if (row == maxRow)
                    {
                        col = maxCol;
                    }
                    else
                    {
                        col = colNumber - 1;
                    }
                }
                else
                {
                    col = col - 1;
                }
            }
            else if (NextMoveCommand == Vector2.right)
            {
                if(row == maxRow)
                {
                    if (col == maxCol)
                    {
                        col = 0;
                    }
                    else
                    {
                        col += 1;
                    }
                }
                else
                {
                    if (col == colNumber - 1)
                    {
                        col = 0;
                    }
                    else
                    {
                        col += 1;
                    }
                }
            }
            cursorIndex = row * colNumber + col;
            NextMoveCommand = Vector2.zero;
            RenderCursor();
        }

        //detail 커서 움직임 
        private void DetailMoveCursor()
        {
            if (NextMoveCommand == Vector2.left)
            {
                if (cursorIndex == 0)
                {
                    cursorIndex = 0;
                }
                else
                {
                    cursorIndex = cursorIndex - 1;
                }

            }
            else if (NextMoveCommand == Vector2.right)
            {
                if (cursorIndex == keyWordTextObj.Count - 1)
                {
                    cursorIndex = keyWordTextObj.Count - 1;
                }
                else
                {
                    cursorIndex = cursorIndex + 1;
                }

            }

            NextMoveCommand = Vector2.zero;
            RenderCursor();
        }
        private void ShowEvidence()
        {
            if (DataManager.Instance.evidences.Count > 0 && cursorIndex < DataManager.Instance.evidences.Count)
            {
                DataManager.Instance.evidences[cursorIndex].Action();
                NextCommand = KeyCode.None;
            }
        }
        private void MoveDetail() //
        {
            detailObjSetactive = true ; //나중에 끌 때 false으로 바꿔주기  

            detailObj.SetActive(true);
            NextCommand = KeyCode.None;
            
            //이미지 
            characterFileName = suspectsObject[cursorIndex].name;

            Sprite detailImageSprite = ResourceLoader.LoadSprite(characterFileName);
            detailImage.sprite = detailImageSprite;
            //설명text 이미지
            string characterDescription = suspectsObject[cursorIndex].name+"Description";
            Sprite detailTextImg = ResourceLoader.LoadSprite(characterDescription);
            detailText.sprite = detailTextImg;


            //키워드들 채우기
            FillKeyword();

            suspectsObj.SetActive(false);
            cursorIndex = 0;
            Destroy(cursor);
            cursor = null;

            //커서 만들기 
            RenderCursor();

        }

        private void FillKeyword()
        {

            for (int i = 0; i < keyWordTextObj.Count; i++)
            {
                switch (characterFileName)
                {
                    case "straw":
                        keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.strawDialogeKeywords[i];
                        Debug.Log("딸기 키워드?");
                        break;
                    case "pancake":
                        keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.pancakeDialogeKeywords[i];
                        Debug.Log("팬케이크 키워드?");
                        break;
                    case "crois":
                        keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.croisDialogeKeywords[i];
                        break;
                    case "maca":
                        keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.macaDialogeKeywords[i];
                        break;
                    case "jelly":
                        keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.jellyDialogeKeywords[i];
                        break;
                    case "jam":
                        keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.jamDialogeKeywords[i];
                        break;
                    case "hodu":
                        keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.hoduDialogeKeywords[i];
                        break;
                    case "donut":
                        keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.donutDialogeKeywords[i];
                        Debug.Log("도넛 키워드?");
                        break;
                    case "twist":
                        keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.twistDialogeKeywords[i];
                        break;
                    case "choco":
                        keyWordTextObj[i].text = GameModel.Instance.TalkBoxData.chocoDialogeKeywords[i];
                        break;
                    default:
                        break;


                }
                //if (characterFileName == "straw")
                //    keyWordTextObj[i].text = TalkBoxData.Instance.strawDialogeKeywords[i];
                //else if (characterFileName == "pancake")
                //    keyWordTextObj[i].text = TalkBoxData.Instance.pancakeDialogeKeywords[i];
                //else if (characterFileName == "cake")
                //    keyWordTextObj[i].text = TalkBoxData.Instance.cakeDialogeKeywords[i];
                //else if (characterFileName == "crois")
                //    keyWordTextObj[i].text = TalkBoxData.Instance.croisDialogeKeywords[i];
                //else if (characterFileName == "maca")
                //    keyWordTextObj[i].text = TalkBoxData.Instance.macaDialogeKeywords[i];
                //else if (characterFileName == "jelly")
                //    keyWordTextObj[i].text = TalkBoxData.Instance.jellyDialogeKeywords[i];
                //else if (characterFileName == "jam")
                //    keyWordTextObj[i].text = TalkBoxData.Instance.jamDialogeKeywords[i];
                //else if (characterFileName == "hodu")
                //    keyWordTextObj[i].text = TalkBoxData.Instance.hoduDialogeKeywords[i];
                //else if (characterFileName == "donut")
                //    keyWordTextObj[i].text = TalkBoxData.Instance.donutDialogeKeywords[i];
                //else if (characterFileName == "twist")
                //    keyWordTextObj[i].text = TalkBoxData.Instance.twistDialogeKeywords[i];
                //else if (characterFileName == "choco")
                //    keyWordTextObj[i].text = TalkBoxData.Instance.chocoDialogeKeywords[i];
            }
        }
        //대화탭 -> 캐릭터 선택 -> 캐릭터 대화 정보 창에서 스페이스바를 누르면 해당 대화를 보여준다. 
        private void showDialogeText()
        {

            string textKTW = keyWordTextObj[cursorIndex].text;
            keywordTextViewText.text = ResourceLoader.LoadDialogeText(textKTW); //게임모델
            keywordTextView.SetActive(true);
            keywordTextViewBool = true; 



        }
        private void Exit()
        {
            GameModel.Instance.StateManager.UndoState();
            NextCommand = KeyCode.None;
            gameObject.SetActive(false);
        }

        private void Awake()
        {

        }
    }

}