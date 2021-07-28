using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using HappyBread.GamePlay.GameState;

namespace HappyBread.GamePlay
{
    public class forSetting : MonoBehaviour
    {
        public GameObject settingPanel;

        public void Click()
        {
            //패널 나타남 
            settingPanel.SetActive(true);
            //state 바꾸기 
            //GameModel.Instance.StateManager.ChangeState(new PlayingState());
            GameModel.Instance.StateManager.ChangeState(new CaseDiaryState());
        }

        public void Esc()
        {
            settingPanel.SetActive(false);
            GameModel.Instance.StateManager.ChangeState(new PlayingState());
        }
    }
}