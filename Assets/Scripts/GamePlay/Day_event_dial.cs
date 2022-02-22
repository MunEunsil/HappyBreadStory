using HappyBread.ETC;
using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

namespace HappyBread.GamePlay
{
    public class Day_event_dial : Event
    {
        public GameObject GO;
        PlayableDirector playableDirector;
        public string FileName { private get; set; }

        public Day_event_dial(string filename)
        {
            FileName = filename;
        }
        protected override void BeginDetail()
        {
            GO = GameObject.Find("GameObject");
            playableDirector = GO.GetComponent<PlayableDirector>();

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
            playableDirector.Play();


        }
    }
}
