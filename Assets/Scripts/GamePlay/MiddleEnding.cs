using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using HappyBread.ETC;
using HappyBread.GamePlay.GameState;
using UnityEngine.SceneManagement;

namespace HappyBread.GamePlay
{
    public class MiddleEnding : MonoBehaviour
    {
        /// <summary>
        /// 중간엔딩을 관리하는 씬 
        /// </summary>
        /// 

        //나중에 엔딩모음 만들 때 수정 필요 
        public GameObject endingImage;
        public KeyCode NextCommand;


        public void Start()
        {
            string MImage = DataManager.Instance.middleEndingName;
            endingImage.GetComponent<Image>().sprite = ResourceLoader.LoadSprite(MImage);
            SceneManager.UnloadScene("map1_1"); //day에 따라 다르게 해야함으로 코드 추가 필요 
        }


        private void Update()
        {
            ////keyMiddleEndingExit 

            if (NextCommand != KeyCode.None)
            {
                if (NextCommand == KeyCode.Space)
                {
                    Debug.Log("미드엔딩 스테이트 에서 스페이스바 누름 ");
                    NextCommand = KeyCode.None;

                    SceneManager.LoadScene("Opening", LoadSceneMode.Additive);
                    SceneManager.UnloadScene("Player");
                    GameModel.Instance.MiddleEnding.gameObject.SetActive(false);

                }

            }


        }

    }
}
