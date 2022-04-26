using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HappyBread.GamePlay.GameState;
namespace HappyBread.GamePlay
{
    public class day3FreezerDoor : Interactable
    {
        /// <summary>
        /// day3 이후 냉동실 출입을 관리
        /// </summary>

        public GameObject B1Door;
        private GameObject b1door;

        public override void Interact()
        {
            
          //  Invoke("IsStopMouse", 2.5f); //2.5초 뒤에 실행 

            if (DataManager.Instance.Day3_freezerKey == true && !DataManager.Instance.inPriz) // 냉동실 키가있고 냉동실안에 없으면
            {
                GameModel.Instance.StateManager.ChangeState(new PauseState());
                // 대화 이벤트 이후 : 현재 플레이어 위치 냉동실 밖 문앞 -> 냉동실안 문앞 
                DataManager.Instance.inPriz = true;
                B1Door.GetComponent<B1Door>().timerStart();

                GameModel.Instance.EventManager.AddBlockingEvent(new B1DoorDialogueEvent("B1_Door_1"));

                //B1DoorDialogueEvent    
            }
            else if (DataManager.Instance.inPriz == true) //냉동실 안에서 상호작용 하면
            {
                GameModel.Instance.StateManager.ChangeState(new PauseState());
                //안에서 밖으로 플레이어 위치 이동  
                //GameModel.Instance.Player.transform.position = new Vector3(2.72f, -0.3f, 1);
                B1Door.GetComponent<B1Door>().timerStop();
                DataManager.Instance.inPriz = false;
                GameModel.Instance.AudioManager.PlayEffectAudio("door"); //EffectAudio("door");
                GameModel.Instance.EffectManager.Fade();
                Invoke("IsStopMouse", 2.0f);
                Invoke("changePP", 1.0f);

            }
            else //냉동실 키가 없으면
            {
                //대화 이벤트만 진행
                //B1_Door_lock
                GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("B1_Door_lock"));
            }


        }
        private void changePP()
        {
            GameModel.Instance.Player.transform.position = new Vector3(2.94f, 0.43f, 1);
        }

        protected override void InitEvidence()
        {
            
        }

        private void Start()
        {
           // B1Door.GetComponent<B1Door>().inPriz = true; //들어갔을 때 inPiz true
        }

        private void IsStopMouse()
        {
            GameModel.Instance.StateManager.ChangeState(new PlayingState());

        }

    }
}