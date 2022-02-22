using HappyBread.Core;
using HappyBread.ETC;
using HappyBread.GamePlay.GameState;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace HappyBread.GamePlay
{
    public class RoomInvestigate : MonoBehaviour
    {

        public KeyCode NextCommand;
        public KeyCode NextFunctionCommand;
        

        public Canvas RoomCanvas;    //raycast가 될 캔버스
        private GraphicRaycaster gr;
        private PointerEventData ped;

        public float clickControll = 0f; //광클 못하게 하기 위함 


        //조사할 수 있는 오브젝트 리스트
        //public List<GameObject> roomObject = new List<GameObject>();

        //public List<Evidence> roomEvidence = new List<Evidence>();
        
        //private void OnEnable()
        //{
        //    GameModel.Instance.StateManager.ChangeState(new RoomInvestigateState());
        //    //cursorIndex = 0;
        //    //Render();
        //}

        private void Update()
        {

            //광클 못학 ㅔ하기 위함 
            if (clickControll > 0)
            {
                clickControll = clickControll - Time.deltaTime;
            }
            else
            {
                clickControll = 0;
            }

            //if (Input.GetKeyUp(KeyCode.Mouse0)) //마우스 좌클릭
            //{
            //    //NextFunctionCommand = GlobalGameData.keyCodeInteract;
            //    ////ClickInteract();
            //}
            //else 
            //if (Input.GetKeyUp(KeyCode.Escape)) //esc
            //{
            //    //Exit();
            //    NextFunctionCommand = KeyCode.Escape;
            //}


            if (NextFunctionCommand != KeyCode.None)
            {
                Debug.Log("nextFuntionCommand 안에는 들어갔는가!!");
                switch (NextFunctionCommand)
                {
                    case GlobalGameData.mouseClick:
                        Debug.Log("클릭인터랙션 전은 가능한가");
                        if (clickControll <=0)
                        {
                            ClickInteract();
                        }
                        break;
                    case KeyCode.Escape:
                        //debug.log("esc누름");
                      //  Exit();
                        break;
                    default:
                        break;
                }
            }


        }

        private void ClickInteract()
        {
            clickControll = 1.5f; //1.5초간 클릭 못하게 할거임

            Debug.Log("마우스 클릭 함");
            ped.position = Input.mousePosition;
            List<RaycastResult> results = new List<RaycastResult>(); // 여기에 히트 된 개체 저장
            

            gr.Raycast(ped, results);
            if (results.Count != 0)
            {
                GameObject obj = results[0].gameObject;
                Interact(obj);
                Debug.Log("hit !");

            }
            else
            {
                //사건에 필요한 증거는 아닌 것 같다. 넣기 
                Debug.Log("사건에 필요한 증거x");
                GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("uninterestedClick"));
            }
            NextFunctionCommand = KeyCode.None;
        }

        private void Interact(GameObject hit)
        {
            //  GameObject HitCast = hit.transform.gameObject;

            Interactable interactable = hit.transform.GetComponent<Interactable>();

            if (interactable != null)
            {

                interactable.Interact();

            }
            else
            {
                Debug.Log("Can't Find Interactable");
            }
        }

        //나가기 버튼 
        public void Exit() 
        {
            // GameModel.Instance.StateManager.UndoState();
            gameObject.SetActive(false);
            GameModel.Instance.Player.inRoom = false;
            GameModel.Instance.StateManager.ChangeState(new PlayingState());

            NextFunctionCommand = KeyCode.None;

            GameModel.Instance.UIManager.BasicUIAppear();



        }

        private void Start()
        {
            GameModel.Instance.StateManager.ChangeState(new RoomInvestigateState());
            clickControll = 0f;
            gr = RoomCanvas.GetComponent<GraphicRaycaster>();
            ped = new PointerEventData(null);
            NextFunctionCommand = KeyCode.None;
            //
        }

    }
}

