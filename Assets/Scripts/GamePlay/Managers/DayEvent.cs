﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.SceneManagement;
using HappyBread.GamePlay.GameState;

namespace HappyBread.GamePlay
{
    public class DayEvent : MonoBehaviour
    {
        public KeyCode NextCommand;
        private bool timeLineP = false;

        public PlayableDirector playableDirector;
        public TimelineAsset timeline;

        public string NextSceneName; //다음 씬 이름 
        public string ThisSceneName; //해당 씬 이름 

        public GameObject day4;

        private enum State
        {
            Idle,       // Dialogue가 들어와있지 않은 상태
            Waiting,    // 타임라인 진행중인 상태
            NonBlocking // 타임라인 끝나고 다음 임력을 받을 수 있는 상태
        }
        private State state;


        // Update is called once per frame
        void Update()
        {
            switch (state)
            {
                case State.Idle:
                    if (Input.GetKeyUp(KeyCode.Space))
                    {
                        if (timeLineP == false)
                        {
                            //타임라인 시작
                            PlayTimeLine();
                        }
                        else
                        {
                            //다음씬으로 넘기기
                        }
                    }
                    break;
                case State.Waiting:
                    if (NextCommand == KeyCode.Space)
                    {
                        if (state == State.Waiting)
                        {

                        }
                    }
                    else if (NextCommand == KeyCode.Escape)
                    {
                        Debug.Log("esc 누름");

                    }
                    break;
                case State.NonBlocking:
                    if (NextCommand == KeyCode.Space)
                    {

                    }
                    else if (NextCommand == KeyCode.Escape)
                    {
                        Debug.Log("esc 누름");

                    }
                    break;
                default:
                    break;
            }
        }

        private void PlayTimeLine()
        {
            playableDirector.Play();
            state = State.Waiting;
           
        }
        public void nextScene()
        {
            state = State.Idle;
            timeLineP = true;

            GameModel.Instance.EffectManager.FadeIn();
            GameModel.Instance.AudioManager.PlayBackgroundAudio();
            //이벤트가 끝날 때 불러올 함수
            //현재 씬 삭제 
            //다음 씬 불러오기
            //state변경 
            GameModel.Instance.Hp.hp = 300f;
            SceneManager.LoadScene(NextSceneName, LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync(ThisSceneName);
            GameModel.Instance.UIManager.BasicUIAppear();
            playerPosition();
            GameModel.Instance.Player.inRoom = false;
            GameModel.Instance.StateManager.ChangeState(new PlayingState());

        }
        public void day4_twist_dial()
        {
            GameModel.Instance.Hp.hp = 300f;
            timeLineP = true;
            state = State.Idle;
            day4.SetActive(false);
            GameModel.Instance.EventManager.AddBlockingEvent(new Day4_Twist_event("day4_twist_event"));
        }

        public void day3_twist_dial()
        {
            GameModel.Instance.Hp.hp = 300f;
            timeLineP = true;
            state = State.Idle;
            day4.SetActive(false);
            GameModel.Instance.EventManager.AddBlockingEvent(new Day4_Twist_event("day3_twist_event"));
        }

        private void Start()
        {
            GameModel.Instance.UIManager.BasicUIHide();
            GameModel.Instance.StateManager.ChangeState(new CallState());
            GameModel.Instance.AudioManager.StopBackgroundAudio();
        }

        private void playerPosition()
        {
            if (DataManager.Instance.date == 2)
            {
                Debug.Log("플레이어 위치 바꿈?");
                GameModel.Instance.Player.transform.position = new Vector3(2.72f, -0.3f, 1);
            }
           
        }




    }
}