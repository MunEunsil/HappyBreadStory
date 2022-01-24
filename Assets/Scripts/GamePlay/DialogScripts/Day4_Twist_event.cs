using HappyBread.ETC;
using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using HappyBread.GamePlay.GameState;

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
            FileName = null;
            GameModel.Instance.EffectManager.FadeIn();
            GameModel.Instance.AudioManager.PlayBackgroundAudio();

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
                ;
                GameModel.Instance.Player.inRoom = false;
                GameModel.Instance.StateManager.ChangeState(new PlayingState());
            }


        }
    }
}

