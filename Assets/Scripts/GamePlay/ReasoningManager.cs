﻿using HappyBread.ETC;
using UnityEngine;
using UnityEngine.UI;

namespace HappyBread.GamePlay
{
    public class ReasoningManager : MonoBehaviour
    {
        /// <summary>
        /// 추리쇼를 관리하는 클래스
        /// </summary>

        public GameObject bgi; //추리쇼 배경 이미지
        public GameObject caseDiary;
        CaseDiary casediary;
        public KeyCode NextCommand;



        private string ArguementCharacterName;  //지목한 캐릭터 이름 


        public Vector2 NextMoveCommand { get; internal set; }

        // Start is called before the first frame update
        void Start()
        {
            casediary = caseDiary.GetComponent<CaseDiary>();

            //추리시작 이미지 나타나기 & 추리시작 글씨 나타내기 (다른캐릭터들도ㅇ)

            //추리쇼 배경 이미지 켜기 (다른 캐릭터X)
            bgi.GetComponent<Image>().sprite = ResourceLoader.LoadSprite("추리배경");

            //인물선택 ui 보여주기 
            showSuspects();


        }

        void showSuspects()  //사건수첩의 인물을 보여줌
        {
            //인물탭을 보이게 해야함             
            caseDiary.SetActive(true);

            //   IsEvidenceWindow  // false : 증거화면 , true : 대화화면 

            if (casediary.IsEvidenceWindow == false) //증거화면이 on
            {
                casediary.evidenceWindow.SetActive(false);
                casediary.talkBoxWindow.SetActive(true);
                casediary.IsEvidenceWindow = true; //캐릭터 나오는 화면on


                casediary.RenderCursor();
            }
            else
            {

                casediary.RenderCursor();

            }

        }
        // Update is called once per frame
        void Update()
        {
            // 방향키를 누르는 경우
            if (NextMoveCommand != Vector2.zero)
            {
                Debug.Log("방향키 누름 ");
                MoveCursor();
            }

            if (NextCommand != KeyCode.None)
            {
                if (NextCommand == KeyCode.Space)
                {
                    ArguementCharacterName = casediary.suspectsObject[casediary.cursorIndex].name;
                    StartArguement();

                    NextCommand = KeyCode.None;
                }
            }

        }
        void MoveCursor()
        {
            
            int row = casediary.cursorIndex / 6;
            int col = casediary.cursorIndex % 6;
            int maxRow = 0;
            int maxCol = 0;

            maxRow = (casediary.suspectsObject.Count - 1) / 6;
            maxCol = (casediary.suspectsObject.Count - 1) % 6;
            // row = cursorIndex / 6;
            //  col = cursorIndex % 6;

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
                        col = 6 - 1;
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
                    if (col == 6 - 1)
                    {
                        col = 0;
                    }
                    else
                    {
                        col += 1;
                    }
                }
            }
            casediary.cursorIndex = row * 6 + col;
            NextMoveCommand = Vector2.zero;
            casediary.RenderCursor();
        }

        void StartArguement()
        {
            //대화시작 
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("argument_" + ArguementCharacterName + "_1"));
            //대화 끝나면 증거 탭 열기 
            //증거 선택하면 증거에 대한 추리 고르게 하기 
            //그에 대한 대화 
            //증거 선택하기 
            //대화



        }

    }
}

       

    


