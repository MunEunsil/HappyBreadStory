using HappyBread.Core;
using HappyBread.ETC;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace HappyBread.GamePlay
{
    public class RoomInvestigate : MonoBehaviour
    {
        public GameObject cursorPrefab;
        public KeyCode NextCommand;
        public int cursorIndex;
        public GameObject cursor;
        public KeyCode NextFunctionCommand;

        public Vector2 NextMoveCommand { get; internal set; }

        //조사할 수 있는 오브젝트 리스트
        public List<GameObject> roomObject = new List<GameObject>();

        //public List<Evidence> roomEvidence = new List<Evidence>();
        
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
                cursor = Instantiate(cursorPrefab, roomObject[cursorIndex].transform);
            }

            if (cursorIndex < roomObject.Count)
            {
                cursor.transform.SetParent(roomObject[cursorIndex].transform);
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
                if (NextCommand ==KeyCode.Space)
                {
                    Debug.Log("스페이스바 누름 ");
                    Interact(roomObject[cursorIndex]);
                    NextCommand = KeyCode.None;
                }
                else if(NextCommand == KeyCode.B)
                {
                    Exit();
                }

            }

        }

        private void Interact(GameObject robj)
        {
            Interactable interactable = robj.GetComponent<Interactable>();
            if (interactable != null)
            {
                interactable.Interact();
                
            }
            else
            {
                Debug.Log("Can't Find Interactable");
            }
        }

        //위 아래 빼고 오직 왼/오 만 가능학 ㅔ할 예정임 
        private void MoveCursor()
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
                if(cursorIndex == roomObject.Count-1)
                {
                    cursorIndex = roomObject.Count- 1;
                }
                else
                {
                    cursorIndex = cursorIndex + 1;
                }  
                
            }

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

