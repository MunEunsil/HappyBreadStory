using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class FloorManager : MonoBehaviour
    {
        public GameObject[] floors;
        private int from, to;
        private Vector3 exitPos;
        public void ChangeFloor(int from, int to, Vector3 exitPos)
        {
            this.from = from;
            this.to = to;
            this.exitPos = exitPos;
            GameModel.Instance.StateManager.ChangeState(new PauseState());
            GameModel.Instance.EffectManager.FadeOut();
            Invoke("ChangeFloor", 2f);
        }

        private void ChangeFloor()
        {
            floors[from].SetActive(false);
            floors[to].SetActive(true);
            GameModel.Instance.Player.transform.position = exitPos;
            GameModel.Instance.EffectManager.FadeIn(0.2f);
            GameModel.Instance.StateManager.Resume();
        }

        private void Start()
        {
            //floors b1 ,1f,2f,3f 자동으로 들어가게 하기 
            
        }

    }
}