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



        public Vector2 NextMoveCommand { get; internal set; }

        //조사할 수 있는 오브젝트 리스트
        public List<GameObject> roomObject = new List<GameObject>();

        //public List<Evidence> roomEvidence = new List<Evidence>();
        
        //private void OnEnable()
        //{
        //    GameModel.Instance.StateManager.ChangeState(new RoomInvestigateState());
        //    //cursorIndex = 0;
        //    //Render();
        //}

        private void Update()
        {
            if (NextFunctionCommand != KeyCode.None)
            {
                Debug.Log(NextFunctionCommand);
                switch (NextFunctionCommand)
                {
                    //case GlobalGameData.keyCodeInteract:
                    //    AttemptInteract();
                    //    break;
                    case GlobalGameData.mouseClick:
                        ClickInteract();
                        break;
                    case KeyCode.Escape:
                        Debug.Log("esc누름");
                        Exit();
                        break;
                    default:
                        break;
                }
            }


            }

        private void ClickInteract()
        {
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

        private void Exit()
        {
          //  GameModel.Instance.StateManager.UndoState();
            GameModel.Instance.StateManager.ChangeState(new PlayingState());

            NextFunctionCommand = KeyCode.None;
            gameObject.SetActive(false);
           

        }

        private void Start()
        {
            GameModel.Instance.StateManager.ChangeState(new RoomInvestigateState());
            
            gr = RoomCanvas.GetComponent<GraphicRaycaster>();
            ped = new PointerEventData(null);
        }

    }
}

