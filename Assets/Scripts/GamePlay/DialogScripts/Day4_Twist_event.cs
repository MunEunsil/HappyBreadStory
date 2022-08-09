using HappyBread.ETC;
using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HappyBread.GamePlay
{
    public class Day4_Twist_event : Event
    {

        public string FileName { private get; set; }

        public Day4_Twist_event(string filename)
        {
            FileName = filename;
        }
        protected override void BeginDetail()
        {
            if (FileName != null)
            {
                GameModel.Instance.Dialogue.Execute(ResourceLoader.LoadText(FileName));
                GameModel.Instance.Dialogue.ConnectedEvent = this;

            }
            else
            {
                Debug.Log("파일 명이 비어있습니다.");
                End();
            }
        }

        protected override void EndDetail()
        {
            GameModel.Instance.AudioManager.ChangeBackgroundAudio("Dance_Of_The_Sugar_Plum_Fairies"); //기본브금
            DataManager.Instance.stopVoice = false;
            FileName = null;
            GameModel.Instance.EffectManager.FadeIn();
           // GameModel.Instance.AudioManager.PlayBackgroundAudio();
            GameModel.Instance.Hp.stopHp = false; //hp감소 

            DataManager.Instance.WEff = true; //hp감소 이펙트 true


            if (DataManager.Instance.date == 3)
            {
                SceneManager.LoadScene("Map3_1", LoadSceneMode.Additive);

                SceneManager.UnloadSceneAsync("Day3_event");
                GameModel.Instance.UIManager.BasicUIAppear();
                ;
                GameModel.Instance.Player.inRoom = false;
                GameModel.Instance.StateManager.ChangeState(new PlayingState());
            }
            else
            {
                SceneManager.LoadScene("Map4_1", LoadSceneMode.Additive);

                SceneManager.UnloadSceneAsync("Day4_event");
                GameModel.Instance.UIManager.BasicUIAppear();
                

                
                GameModel.Instance.Player.inRoom = false;
                GameModel.Instance.StateManager.ChangeState(new PlayingState());
            }
            GameModel.Instance.Player.transform.position = new Vector3(2.72f, -0.3f, 1);
           // Debug.Log("플레이어 위치 바꿈?");


        }
    }
}

