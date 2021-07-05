using HappyBread.GamePlay;
using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HappyBread.GamePlay
{
    public class evningEvent : MonoBehaviour
    {
        /// <summary>
        /// 저녁이벤트를 관리하는 클래스
        /// </summary>
        [SerializeField]
        private List<GameObject> images = new List<GameObject>();   //이미지들을 넣어서 활용할 리스트 

        //public string NextSceneName; //다음 씬 이름 
        public string ThisSceneName; //해당 씬 이름 

        private int listIndex = 0;
        int date = GameModel.Instance.Date.Current;


        // Start is called before the first frame update
        void Start()
        {
            GameModel.Instance.StateManager.ChangeState(new DayEventState());

            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent($"Day{date}_evningEvent"));

            listIndex = 0;
        }

        // Update is called once per frame
        void Update()
        {

            if (DataManager.Instance.Day_nextCommand != KeyCode.None)
            {
                if (DataManager.Instance.Day_nextCommand == KeyCode.Space) //or 마우스 좌클릭일 때
                {
                    Debug.Log("스페이스바 누름");
                    if (listIndex == images.Count - 1)
                    {
                        LoadNextMap();
                    }
                    else
                    {
                        //이미지 넘기기
                        images[listIndex].SetActive(false);
                        images[listIndex + 1].SetActive(true);
                        listIndex += 1;
                    }
                    DataManager.Instance.Day_nextCommand = KeyCode.None;
                }
            }
        }

        //씬 불러올 함수 만들기 
        private void LoadNextMap()
        {
            //이벤트가 끝날 때 불러올 함수
            //현재 씬 삭제 
            //다음 씬 불러오기
            //state변경 
            SceneManager.LoadScene($"Map{date}_1", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync(ThisSceneName);

            GameModel.Instance.StateManager.ChangeState(new PlayingState());
            GameModel.Instance.Hp.Set(300f);

        }
        private void LoadMorningEvent()
        {

        }
    }
}
