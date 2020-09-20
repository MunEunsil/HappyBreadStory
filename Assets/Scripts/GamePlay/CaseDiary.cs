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
            // 좌우 화살표
            // 1. 해당 줄의 최대 가로 길이일 때, 0으로 보낸다.
            // 2. 0일 때, 해당 가로 줄의 최대 길이로 보낸다.

            // 상하 화살표
            // 1. 해당 줄의 최대 세로 길이일 때, 0으로 보낸다.
            // 2. 0일 때, 해당 세로 줄의 최대 길이로 보낸다.

            // 최대 가로 인덱스
            // index - (cursorRow * colNumber)

            // 최대 세로 인덱스
            // totalRow - ( index + colNumber >= totalIndex ? 0 : 1 )

            int row = cursorIndex / colNumber;
            int col = cursorIndex % colNumber;
            int totalRow = evidencesObject.Count / colNumber -
                ((evidencesObject.Count - 1) - ((evidencesObject.Count / colNumber) * colNumber) < col ? 1 : 0);
            int totalCol = row == (evidences.Count / colNumber) ? (evidencesObject.Count - 1) - (row * colNumber) : colNumber - 1;
            Debug.Log(totalRow);
            if (NextMoveCommand == Vector2.up)
            {
                if(row - 1 < 0)
                {
                    row = totalRow;
                }
                else
                {
                    row = row - 1;
                }
            }
            else if(NextMoveCommand == Vector2.down)
            {
                if (row + 1 > totalRow)
                {
                    row = 0;
                }
                else
                {
                    row = row + 1;
                }
            }
            else if (NextMoveCommand == Vector2.left)
            {
                if(col - 1 < 0)
                {
                    col = totalCol;
                }
                else
                {
                    col = col - 1;
                }
            }
            else if (NextMoveCommand == Vector2.right)
            {
                if(col + 1 > totalCol)
                {
                    col = 0;
                }
                else
                {
                    col = col + 1;
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
            for (int idx = 0; idx < 29; idx++)
            {
                evidences.Add(new Evidence()
                {
                    Name = "Block",
                    Content = "정체를 알 수 없는 블록이다.",
                    Sprite = "stone",
                    Action = () =>
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("stone"));
                    }
                });
            }
        }
    }

}