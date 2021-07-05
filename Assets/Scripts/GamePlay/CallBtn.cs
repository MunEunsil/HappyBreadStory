using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HappyBread.GamePlay.GameState;
using UnityEngine.SceneManagement;

namespace HappyBread.GamePlay
{
    public class CallBtn : MonoBehaviour
    {

        public void Appear()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
        public void ClickCall()
        {
            //.SetActive(true);
            //state 변경 
            GameModel.Instance.EffectManager.FadeIn();
            SceneManager.LoadScene("CallEvent", LoadSceneMode.Additive);
            GameModel.Instance.StateManager.ChangeState(new CallState());
            
            //GameModel.Instance.StateManager.ChangeState(new ReasoningState());

        }
    }

}

