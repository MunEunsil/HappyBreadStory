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
        public int cursorIndex;
        private int colNumber = 8;
        public GameObject cursor;

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
            if(evidencesObject.Count == 0) // 비어 있으면 아무 일도 일어나지 않는다.
            {
                return;
            }

            if(cursor == null) // 아직 생성되지 않았다면 생성한다.
            {
                cursor = Instantiate(cursorPrefab, evidencesObject[cursorIndex].transform);
            }

            if(cursorIndex < evidencesObject.Count)
            {
                cursor.transform.SetParent(evidencesObject[cursorIndex].transform);
                cursor.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            }
        }

        private void Update()
        {
            // 방향키를 누르는 경우
            if (NextMoveCommand != Vector2.zero)
            {
                MoveCursor();
            }

            // A를 눌렀을 경우
            if (NextCommand != KeyCode.None)
            {
                if (NextCommand == KeyCode.A)
                {
                    Exit();
                }
                else if (NextCommand == KeyCode.Space)
                {
                    ShowEvidence();
                }
            }
        }

        private void MoveCursor()
        {
            int row = cursorIndex / colNumber;
            int col = cursorIndex % colNumber;
            int maxRow = (evidencesObject.Count - 1) / colNumber;
            int maxCol = (evidencesObject.Count - 1) % colNumber;

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