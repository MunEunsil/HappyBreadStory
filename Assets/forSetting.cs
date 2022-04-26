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
        
        //매뉴얼 배열

        public GameObject[] manual = new GameObject[7];
        //매뉴얼 인덱스
        private int manualIndex = 0;


        public void Click()
        {
            //패널 나타남 
            settingPanel.SetActive(true);
            //음향켜고 
            audioTab.SetActive(true);
            //겜설명 끄기
            operationKeyTab.SetActive(false);
            //hp감소 멈추기 
            GameModel.Instance.Hp.stopHp = true;

            GameModel.Instance.Player.playerStop();
            
            //state 바꾸기 
            //GameModel.Instance.StateManager.ChangeState(new PlayingState());
            GameModel.Instance.StateManager.ChangeState(new CaseDiaryState());
        }

        public void Esc()
        {
            settingPanel.SetActive(false);
            GameModel.Instance.StateManager.ChangeState(new PlayingState());
            //hp감소하기
            GameModel.Instance.Hp.stopHp = false;
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
            manualIndex = 0;
            manual[0].SetActive(true);
            operationKeyTab.SetActive(true);
            
        }

        //조작법 왼쪾 버튼
        public void manualButton_left()
        {
            if (manualIndex != 0)
            {
                manualIndex--;
                manual[manualIndex + 1].SetActive(false);
                manual[manualIndex].SetActive(true);

            }
            //else
            //{
            //    manualIndex--;
            //    manual[manualIndex - 1].SetActive(false);
            //    manual[manualIndex].SetActive(true);
            //}


        }
        //조작법 오른쪽 버튼
        public void manualBuuton_right()
        {
            //6
            if (manualIndex<6)
            {
                manualIndex++;
                manual[manualIndex - 1].SetActive(false);
                manual[manualIndex].SetActive(true);

            }

        }

    }
}