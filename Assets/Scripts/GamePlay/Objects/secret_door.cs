using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HappyBread.GamePlay;
using System;
using HappyBread.ETC;
using UnityEngine.SceneManagement;
using HappyBread.GamePlay.GameState;

namespace HappyBread.GamePlay
{
    public class secret_door : Interactable
    {
        /// <summary>
        /// 비밀의 문을 발견했을 때 상호작용
        /// 비밀의 문으로 들어간다 : 곽배기와 대화 후 씬 변경
        /// 비밀의 문으로 들어가지않는다 : 이전상태로
        /// </summary>

        public bool true_ending = false;
        public override void Interact()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("dial_secret_door"));
            List<Event> events = new List<Event>();
            // 2022 08 20 : 들어간다 했을 때 대화 나오고 씬이동 해야함
            //이 아래에 씬 이동까지 해야할듯 
            events.Add(new ActionEvent(() => { GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("dial_hiddenRoom_twist")); moveSecretRoom();
                if (true_ending == true) { DataManager.Instance.hidden_true = true;}
            }));
            events.Add(new ActionEvent(() => {   ; }));
            GameModel.Instance.EventManager.AddBlockingEvent(new AnswerEvent(events));
        }
        protected override void InitEvidence()
        {
        }

        public void moveSecretRoom()
        {
            //씬 이동 
            SceneManager.UnloadSceneAsync($"Map{DataManager.Instance.date}_1");
            SceneManager.LoadScene("Map_hidden_map", LoadSceneMode.Additive);


            GameModel.Instance.Player.inRoom = false;
            GameModel.Instance.StateManager.ChangeState(new PlayingState());

            // 씬 이동시 플레이어 위치 
            GameModel.Instance.Player.transform.position = new Vector3(2.72f, -0.3f, 1);
            // 브금 변경
            // 기존 시간제한 멈춤
            GameModel.Instance.Hp.stopHp = true;
            //새로운 카운트 시작
        }

    }
}