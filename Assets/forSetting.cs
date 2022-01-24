using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HappyBread.GamePlay.GameState;

namespace HappyBread.GamePlay
{
    public class forSetting : MonoBehaviour
    {
        public GameObject settingPanel;

        public GameObject operationKeyTab;
        public GameObject audioTab;


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

        //음향버튼
        public void button_audioTab() 
        {
            //조작키 끔 
            operationKeyTab.SetActive(false);
            //음향 킴 
            audioTab.SetActive(true);
        }
        //조작탭 킴
        public void button_operationKeyTab()
        {
            //음향탭끔
            audioTab.SetActive(false);
            //조작키 켬
            operationKeyTab.SetActive(true);
            

        }

    }
}