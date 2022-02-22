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
    public class RoomDoor : Interactable
    {
        public GameObject Room;

        public KeyCode NextFunctionCommand;

        //private void OnTriggerEnter2D(Collider2D collision)
        //{
        //    if (collision.CompareTag("Player"))
        //    {
                
        //        GameModel.Instance.StateManager.ChangeState(new PauseState());
        //        GameModel.Instance.EffectManager.FadeOut();
        //        Invoke("InterRoom", 2f);
        //        NextFunctionCommand = KeyCode.None;            
        //    }


        //}
        private void InterRoom() 
        {          
            GameModel.Instance.StateManager.ChangeState(new RoomInvestigateState());
            GameModel.Instance.AudioManager.D_Audio("door");
            Room.SetActive(true);
            GameModel.Instance.EffectManager.FadeIn(0.2f);

            GameModel.Instance.StateManager.Resume();

            GameModel.Instance.Player.inRoom = true;
            //ui끄기
            GameModel.Instance.UIManager.BasicUIHide();


           // GameModel.Instance.StateManager.ChangeState(new RoomInvestigateState());

        }
        public override void Interact()
        {
            //GameModel.Instance.UIManager.BasicUIHide();
            //마스터키가 있으면 / 딸기방 열쇠가 있으면 들어 갈 수있게 하기 
            if (this.gameObject.name == "Door206_STRAW")
            {
                if (DataManager.Instance.strawRoomKey == true)
                {
                    GameModel.Instance.UIManager.BasicUIHide();
                    GameModel.Instance.StateManager.ChangeState(new PauseState());
                    GameModel.Instance.EffectManager.FadeOut();
                    Invoke("InterRoom", 2f);
                }
                else if (DataManager.Instance.date >= 3)
                {
                    GameModel.Instance.UIManager.BasicUIHide();
                    GameModel.Instance.StateManager.ChangeState(new PauseState());
                    GameModel.Instance.EffectManager.FadeOut();
                    Invoke("InterRoom", 2f);
                }
            }
            else if (this.gameObject.name == "Door301_USER")
            {
                GameModel.Instance.UIManager.BasicUIHide();
                GameModel.Instance.StateManager.ChangeState(new PauseState());
                GameModel.Instance.EffectManager.FadeOut();
                Invoke("InterRoom", 2f);
            }
            else if (this.gameObject.name == "Door303_감사의방")
            {
                GameModel.Instance.UIManager.BasicUIHide();
                GameModel.Instance.StateManager.ChangeState(new PauseState());
                GameModel.Instance.EffectManager.FadeOut();
                Invoke("InterRoom", 2f);
            }
            else
            {
                //if (DataManager.Instance.masterKey == true)
                //{
                //    GameModel.Instance.StateManager.ChangeState(new PauseState());
                //    GameModel.Instance.EffectManager.FadeOut();
                //    Invoke("InterRoom", 2f);
                //}
                if (DataManager.Instance.date >= 3)
                {
                    GameModel.Instance.UIManager.BasicUIHide();
                    GameModel.Instance.StateManager.ChangeState(new PauseState());
                    GameModel.Instance.EffectManager.FadeOut();
                    Invoke("InterRoom", 2f);
                }

            }

            NextFunctionCommand = KeyCode.None;
        }

        public void exitButton()
        {
            Room.SetActive(false);
            GameModel.Instance.Player.inRoom = false;
            GameModel.Instance.StateManager.ChangeState(new PlayingState());

            GameModel.Instance.UIManager.BasicUIAppear();

        }


        protected override void InitEvidence()   //증거X -> 대화 저장 
        {

        }
    }
}