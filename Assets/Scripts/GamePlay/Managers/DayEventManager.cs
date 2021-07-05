using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HappyBread.GamePlay
{
    public class DayEventManager : MonoBehaviour
    {
        /// <summary>
        /// 각 day의 이벤트를 관리하고 진행하는 클래스
        /// </summary>
        [SerializeField]
        private List<GameObject> images = new List<GameObject>();   //이미지들을 넣어서 활용할 리스트 

        public string NextSceneName; //다음 씬 이름 
        public string ThisSceneName; //해당 씬 이름 
        private int listIndex = 0;

        public KeyCode NextCommand;

        // Start is called before the first frame update
        void Start()
        {
            //스테이트 변경
            listIndex = 0;
        }

        // Update is called once per frame
        void Update()
        {
            if (NextCommand != KeyCode.None)
            {
                if (NextCommand == KeyCode.Space) //or 마우스 좌클릭일 때
                {
                    if (listIndex == images.Count - 1)
                    {
                        eventEnd();
                    }
                    else
                    {
                        //이미지 넘기기
                        images[listIndex].SetActive(false);
                        images[listIndex + 1].SetActive(true);
                        listIndex += 1;
                    }
                }
            }
        }

        //씬 불러올 함수 만들기 
        private void eventEnd()
        {
            //이벤트가 끝날 때 불러올 함수
            //현재 씬 삭제 
            //다음 씬 불러오기
            //state변경 
            SceneManager.LoadScene(NextSceneName, LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync(ThisSceneName); 

        }
    }
}
