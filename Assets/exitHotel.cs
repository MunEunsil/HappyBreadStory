using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HappyBread.GamePlay.GameState;
using System;


namespace HappyBread.GamePlay
{
    public class exitHotel : MonoBehaviour
    {

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                DataManager.Instance.middleEndingName = "middleEnding1";
                GameModel.Instance.StateManager.ChangeState(new MiddleEndingState());


                //ui뿅 
                GameModel.Instance.StateManager.ChangeState(new PauseState());
                GameModel.Instance.EffectManager.FadeOut();

                Invoke("exitHotelEnding", 2f);

            }
        }
        private void exitHotelEnding()
        {
            
            GameModel.Instance.MiddleEnding.gameObject.SetActive(true);

            GameModel.Instance.EffectManager.FadeIn(0.2f);
            GameModel.Instance.StateManager.Resume();
        }
    }

}

