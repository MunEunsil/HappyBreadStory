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
    public class RoomDoor : MonoBehaviour
    {
        public GameObject Room;

        public KeyCode NextFunctionCommand;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                
                GameModel.Instance.StateManager.ChangeState(new PauseState());
                GameModel.Instance.EffectManager.FadeOut();
                Invoke("InterRoom", 2f);
                NextFunctionCommand = KeyCode.None;            
            }


        }
        private void InterRoom()
        {
            Room.SetActive(true);
            GameModel.Instance.EffectManager.FadeIn(0.2f);

            GameModel.Instance.StateManager.Resume();

           // GameModel.Instance.StateManager.ChangeState(new RoomInvestigateState());


        }
    }
}