using HappyBread.Core;
using HappyBread.ETC;
using HappyBread.GamePlay.GameState;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

namespace HappyBread.GamePlay
{
    /// <summary>
    /// 플레이어를 제어 할 수 있는 클래스. 
    /// </summary>
    ///

    public class Player : MovingObject
    {

        [HideInInspector]
        public Vector3 NextMoveCommand; // 다음 움직임 명령
        [HideInInspector]
        public KeyCode NextFunctionCommand;
        public LayerMask interactableLayer;
        public LayerMask evidenceLayer;
        public float hitDistance = 0.5f;
        public float useHpAmount = 0.01f;

        private bool MidEnding = false; //중간엔딩이 꺼져있음 

        private State state;
        private RaycastHit2D hit;

        public bool inRoom; //방 안에 있는지 확인하기 위한 변수


        private void Start()
        {
            state = State.Idle;
            inRoom = false;
        }

        private void Update()
        {
           
            //시간에 따라 식빵 게이지 줄이기
            if (GameModel.Instance.Hp.hp > 0)
            {
                if (DataManager.Instance.callStart == false)  //추리하기 중이 아닐 때 
                {
                    GameModel.Instance.Hp.Add(-Time.deltaTime);
                }

            }
            else
            {
                if (MidEnding == false)
                {
                    GameModel.Instance.MiddleEnding.startMoldEnding();
                    MidEnding = true;
                }  
            }
            //else if(GameModel.Instance.Hp.hp == 0)// 식빵 게이지가 0이면 
            //{
            //    Debug.Log("hp 0임!!");
            //    GameModel.Instance.MiddleEnding.startMoldEnding();
            //}

            //if (GameModel.Instance.Hp.hp<0)
            //{
            //    Debug.Log(GameModel.Instance.Hp.hp);
            //}

            // 움직임 구현부 ( 화살표 키 )
            switch (state)
            {
                case State.Idle:
                    IdleState();
                    break;
                case State.Walking:
                    WalkingState();
                    break;
                default:
                    break;
            }
            
            // 그 외 단축키 구현부 ( 상호작용 키 )
            if (NextFunctionCommand != KeyCode.None)
            {

                switch (NextFunctionCommand)
                {
                    case GlobalGameData.mouseClick:
                        //if()state가 플레이어
                        AttemptInteract();
                        break;
                    case GlobalGameData.keyCodeCaseDiary:
                        Debug.Log(DataManager.Instance.evidences);
                        break;
                    default:
                        break;
                }
                 }
            }

        //CaseDiaryBtn 스크립트에 적용 
        //public void AttemptOpenCaseDiary()
        //{
        //    GameModel.Instance.StateManager.ChangeState(new CaseDiaryState());
        //    GameModel.Instance.CaseDiary.gameObject.SetActive(true);
        //    NextFunctionCommand = KeyCode.None;
        //}
        private void AttemptOpenCall()
        {
            GameModel.Instance.StateManager.ChangeState(new CallState());
            GameModel.Instance.Call.gameObject.SetActive(true);
            NextFunctionCommand = KeyCode.None;

        }

        public void AttemptInteract()  
        {
            if (inRoom == false)
            {
                Vector2 start = transform.position;
                Vector2 end = (Vector2)transform.position + objectDirection * hitDistance;
                hit = Physics2D.Linecast(start, end, interactableLayer);
                if (hit.transform != null)
                {
                    Interact(hit);
                }

            }
            NextFunctionCommand = KeyCode.None;
        }

        private void Interact(RaycastHit2D hit)
        {
            Interactable interactable = hit.transform.GetComponent<Interactable>();
            if(interactable != null)
            {
                interactable.Interact();

            }
            else
            {
                Debug.Log("Can't Find Interactable");
            }
        }

        private void IdleState()
        {
            if (NextMoveCommand != Vector3.zero) // 움직이라는 명령을 받음
            {
                state = State.Walking;
            }
            else
            {
                if (rigidBody2D.velocity != Vector2.zero)
                {
                    Stop();
                }
            }
        }

        private int walk = 0;
        private void WalkingState()
        {
            if (NextMoveCommand != Vector3.zero) // 움직이라는 명령 받음
            {
                //if (walk == 0)
                //{
                //    walk = 1;
                //    GameModel.Instance.AudioManager.PlayEffectAudio("walk");//walk
                //}
                //else
                //{
                //    walk = 0;
                //    GameModel.Instance.AudioManager.PlayEffectAudio("walk1");
                //}

                GameModel.Instance.AudioManager.PlayEffectAudio("walk");//walk
                Move(NextMoveCommand);
            }
            else // 움직임 상태 해제
            {
                state = State.Idle;
            }
        }
        private void SaveGame()
        {
            SaveLoad.instance.SaveGameData();
        }

        protected override void AfterMove()
        {
            //NextMoveCommand = Vector3.zero;
            //GameModel.Instance.Hp.Add(-useHpAmount); // Hp 변동
        }

        //private void startMoldEnding()  
        //{
        //    DataManager.Instance.middleEndingName = "middleEnding4";
        //    GameModel.Instance.StateManager.ChangeState(new MiddleEndingState());

        //    //ui뿅 
        //    GameModel.Instance.StateManager.ChangeState(new PauseState());
        //    GameModel.Instance.EffectManager.FadeOut();

        //    Invoke("moldEnding", 2f);
        //}
        //private void moldEnding() //곰팡이 엔딩
        //{

        //    GameModel.Instance.MiddleEnding.gameObject.SetActive(true);

        //    GameModel.Instance.EffectManager.FadeIn(0.2f);
        //    GameModel.Instance.StateManager.Resume();

        //}

       

    }
}