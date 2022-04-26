using HappyBread.Core;
using HappyBread.ETC;
using HappyBread.GamePlay.GameState;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;

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
        public float hitDistance = 1.0f;
        public float useHpAmount = 0.01f;

        //비네트 효과 
        public PostProcessVolume vignetteEffect;
        public Vignette vignette;

        private bool MidEnding = false; //중간엔딩이 꺼져있음 

        private State state;
        private RaycastHit2D hit;

        public bool inRoom; //방 안에 있는지 확인하기 위한 변수


        private void Start()
        {
            state = State.Idle;
            inRoom = false;
            //DataManager.Instance.vignetterColor.value = new Color(21f, 11f, 22f);
            //vignetteEffect.profile.TryGetSettings(out vignette);
            
        }

        private void Update()
        {
            
            //시간에 따라 식빵 게이지 줄이기
            if (GameModel.Instance.Hp.hp > 0)
            {
                //if (DataManager.Instance.callStart == false)  //추리하기 중이 아닐 때 
                //{
                //    GameModel.Instance.Hp.Add(-Time.deltaTime);
                //}
                if (GameModel.Instance.Hp.stopHp == false)
                {                  
                    GameModel.Instance.Hp.Add(-Time.deltaTime);
                }
                else
                {
                    return;
                }
                

            }
            else
            {
                if (DataManager.Instance.date == 4)
                {
                    GameModel.Instance.DataController.saveData.evidence_Sprite.Clear();


                    SceneManager.UnloadSceneAsync($"Map{DataManager.Instance.date}_1");
                    GameModel.Instance.EventManager.AddBlockingEvent(new NextDayDialogueEvent("Day4_event"));
                }
                else
                {
                    if (MidEnding == false)
                    {
                        GameModel.Instance.MiddleEnding.startMoldEnding();
                        MidEnding = true;
                    }
                }

            }


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


        private void AttemptOpenCall()
        {
            GameModel.Instance.StateManager.ChangeState(new CallState());
            GameModel.Instance.Call.gameObject.SetActive(true);
            NextFunctionCommand = KeyCode.None;

        }

        public void playerStop()
        {            
            Stop();
            NextMoveCommand = Vector3.zero;
        }

        //상호작용을 위한 코드 (은실 - 2020.10.11)
        //플레이어가 오브젝트를 클릭했을 때 실행
        /*
        NPC와 대화는 특정 거리에서 NPC를 바라보고 어딜 크릭해도 상호작용 가능
        오브젝트는 정확하게 물체를 선택해야 가능 (은실 수정— 2022.01.26)
        */

        public void AttemptInteract()  
        {
            Stop(); // 상호작용 중 움직이는 것을 막기 위함 
            
            state = State.Idle;
            if (inRoom == false)
            {
             
                Vector2 start = transform.position;
                Vector2 end = (Vector2)transform.position + objectDirection * hitDistance;
                hit = Physics2D.Linecast(start, end, interactableLayer);

                
                RaycastHit2D hitInfo;
                Vector2 clickPos;
                if (hit.transform != null)
                {
                    clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    hitInfo = Physics2D.Raycast(clickPos, Camera.main.transform.forward, 15f, interactableLayer);
                    //    Interact(hit);

                    if (hitInfo.collider != null)
                    {
                        //Debug.Log("증거 상호작용");
                        Interact(hitInfo);
                    } else if (hit.transform.CompareTag("NPC"))
                    {
                       // Debug.Log("대화 상호작용");
                        Interact(hit);
                    }

                }


            }
            NextFunctionCommand = KeyCode.None;
            NextMoveCommand = Vector3.zero;
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

       

    }
}