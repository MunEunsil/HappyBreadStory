using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace HappyBread.GamePlay
{
    public class EndingManager : MonoBehaviour
    {
        /// <summary>
        /// 엔딩을 관리하는 클래스
        /// </summary>
        /// 

        public GameObject happyEnding;
        public GameObject badEnding;

        public bool HappyImage;
        public GameObject happyEndingImage;

       

        // Start is called before the first frame update
        private void Awake()
        {
          
        }
        void Start()
        {
            GameModel.Instance.UIManager.BasicUIHide();
            

            if (DataManager.Instance.happyEnding == true)
            {
                happyEnding.SetActive(true);
                HappyImage = happyEnding.GetComponent<EndingDialogue>().printState;


            }
            else if(DataManager.Instance.happyEnding == false)
            {
                badEnding.SetActive(true);
            }
        }


        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {

                if (DataManager.Instance.happyEnding == true)
                {
                    happyEndingImage.SetActive(true);
                    //if (HappyImage == true)
                    //{
                    //    happyEnding.GetComponent<EndingDialogue>().printAll();
                    //}


                }
                else if(DataManager.Instance.happyEnding == false)
                {
                    done();
                }

                
            }
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                done();
            }
        }

        void done()
        {
           // SceneManager.UnloadSceneAsync("CallScene"); //콜 씬 지우기 
            SceneManager.UnloadSceneAsync("Ending"); //엔딩 씬 지우기 
            //엔딩씬 지우기 
            SceneManager.LoadScene("Opening", LoadSceneMode.Additive); //오프닝씬 불러오기
        }

    }
}
