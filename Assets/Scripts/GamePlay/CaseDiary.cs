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
        private List<Evidence> evidences = new List<Evidence>();
        private List<GameObject> evidencesObject = new List<GameObject>();   
        public List<GameObject> suspectsObject = new List<GameObject>();    // talkBoxCharacter 

        public int cursorIndex;
        private int colNumber = 8;
        public GameObject cursor;

        //evidenceWindow 확인을 위한 변수 
        private bool IsEvidenceWindow = false; // false : 증거화면 , true : 대화화면 
        //증거/대화들 false면 못찾아서 추가함
        public GameObject evidenceWindow;
        public GameObject talkBoxWindow;


        public Vector2 NextMoveCommand { get; internal set; }

        public void AddEvidence(Evidence evidence)
        {
            evidences.Add(evidence);
        }

        public void DeleteEvidence(int index)
        {
            evidences.RemoveAt(index);
        }

        public bool Contains(Evidence evidence)
        {
            return evidences.Contains(evidence);
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
            foreach (Evidence evidence in evidences)
            {
                GameObject newEvidenceObject = Instantiate<GameObject>(blankEvidenceObject, content.transform);
                newEvidenceObject.GetComponent<Image>().sprite = ResourceLoader.LoadSprite(evidence.Sprite);
                evidencesObject.Add(newEvidenceObject);
            }

            // 커서를 새로 그린다.
            RenderCursor();
        }
        
        private void RenderCursor()
        {
            if(IsEvidenceWindow == false) //증거화면이 켜있는 상태 
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
            else
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
            }
            
        }

        private void Update()
        {
            // 방향키를 누르는 경우
            if (NextMoveCommand != Vector2.zero)
            {
                MoveCursor();
            }

            if (NextCommand != KeyCode.None)
            {
                if (NextCommand == KeyCode.A) //A 눌렀을 때
                {
                    Debug.Log("a누름");
                    Exit();
                }
                else if (NextCommand == KeyCode.Space) //space 눌렀을 때
                {
                    Debug.Log("스페이스바 누름");
                    ShowEvidence();
                }
                else if (NextCommand ==KeyCode.Tab) // tab 눌렀을 때
                {
                    Debug.Log("tab 눌렀음!");
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
                }
            }
            


            

        }

        //2021 03 05 TalkBoxCusor를위해 수정 
        private void MoveCursor()
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
            else // talkBox
            {
                 colNumber = 10;
                 row = cursorIndex/ colNumber;
                 col = cursorIndex% colNumber;
                 maxRow = 5;
                 maxCol = 2;
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

        private void ShowEvidence()
        {
            if (evidences.Count > 0 && cursorIndex < evidences.Count)
            {
                evidences[cursorIndex].Action();
                NextCommand = KeyCode.None;
            }
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