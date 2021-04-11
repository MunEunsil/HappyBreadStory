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
    /// 범인을 지목하는 기능을 하는 클래스
    /// </summary>
    public class Call : MonoBehaviour
    {


        public GameObject cursorPrefab;
        public KeyCode NextCommand;
        public List<GameObject> suspectsObject = new List<GameObject>();    // talkBoxCharacter 

        public int cursorIndex;
        private int colNumber = 6;
        public GameObject cursor;


        public GameObject talkBoxWindow;


        public Vector2 NextMoveCommand { get; internal set; }


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

            // 커서를 새로 그린다.
            RenderCursor();
        }

        private void RenderCursor()
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

        private void Update()
        {
            // 방향키를 누르는 경우
            if (NextMoveCommand != Vector2.zero)
            {
                MoveCursor();
            }

            if (NextCommand != KeyCode.None)
            {
                if (NextCommand == KeyCode.C) 
                {
                    Exit();
                }
                else if (NextCommand == KeyCode.Space) //space 눌렀을 때
                {
                    // Debug.Log("스페이스바 누름");
                    //ShowEvidence(); // 범인으로 씬 이동?
                }
            
            }

        }


        private void MoveCursor()
        {
            int row = cursorIndex / colNumber;
            int col = cursorIndex % colNumber;
            int maxRow = 0;
            int maxCol = 0;

       
            
             colNumber = 6;
             maxRow = (suspectsObject.Count - 1) / colNumber;
             maxCol = (suspectsObject.Count - 1) % colNumber;
             row = cursorIndex / colNumber;
             col = cursorIndex % colNumber;

          


            if (NextMoveCommand == Vector2.up)
            {
                if (row == 0)
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
            else if (NextMoveCommand == Vector2.down)
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
                if (col == 0)
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
                if (row == maxRow)
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