using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;
using HappyBread.GamePlay.GameState;


namespace HappyBread.GamePlay
{

    public class OpeningAnimManager : MonoBehaviour
    {

        public PlayableDirector playableDirector;
        public TimelineAsset timeline;

        // Start is called before the first frame update
        private void Awake()
        {
            GameModel.Instance.UIManager.BasicUIHide();
        }
        void Start()
        {
            playableDirector.Play();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void nextScene()
        {
            GameModel.Instance.Hp.stopHp = false;

            //timeLineP = true;
            Debug.Log("day1 맵 나와라 뿅");
           // SceneManager.LoadScene("Player", LoadSceneMode.Additive);
            GameModel.Instance.EffectManager.FadeIn();
            GameModel.Instance.AudioManager.PlayBackgroundAudio();
            //이벤트가 끝날 때 불러올 함수
            //현재 씬 삭제 
            //다음 씬 불러오기
            //state변경 
            GameModel.Instance.Hp.hp = 300f;
            SceneManager.LoadScene("Map1_1", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("IntroAnim");
            GameModel.Instance.UIManager.BasicUIAppear();

            GameModel.Instance.Player.inRoom = false;
            GameModel.Instance.StateManager.ChangeState(new PlayingState());
        }

    }
}
