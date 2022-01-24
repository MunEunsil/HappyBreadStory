using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using HappyBread.ETC;
using System.IO;

namespace HappyBread.GamePlay
{
    public class OpeningManager : MonoBehaviour
    {
        /// <summary>
        /// 오프닝 씬을 관리하는 클래스
        /// </summary>
        /// 

        public GameObject[] steps;
        public int currentStep;
        public Text playerName;

        //인포 오브젝트 
        public GameObject info;

        //엔딩 페널
        public GameObject endingPanel;
        //엔딩들 배열 
        public GameObject[] endings = new GameObject[6];
        public GameObject[] finalEnding = new GameObject[2];


        //엔딩 디테일 
        public GameObject endingDetail;



        public void Next()
        {
            GameModel.Instance.EffectManager.FadeOut();
            //데이터 초기화 
            DataInitalization();
            Invoke("SetActiveFalse", 2f);

            if (currentStep + 1 >= steps.Length) // 다음 씬으로 넘어간다.
            {
                //Invoke("NextScene", 2f);
                GameModel.Instance.AudioManager.ChangeBackgroundAudio("Dance_Of_The_Sugar_Plum_Fairies");
                GameModel.Instance.AudioManager.PlayBackgroundAudio();
                return;
            }


            Invoke("SetActiveTrue", 2f);
        }

        //
 
        private void DataInitalization()
        {
            //start눌렀을 때 데이터 초기화를 위함! 
            Debug.Log("데이터 초기화");
            DataManager.Instance.evidences.Clear();
            DataManager.Instance.cake = 0;
            DataManager.Instance.choco = 0;
            DataManager.Instance.crois = 0;
            DataManager.Instance.donut = 0;
            DataManager.Instance.hodu = 0;
            DataManager.Instance.jam = 0;
            DataManager.Instance.jelly = 0;
            DataManager.Instance.jellyjelly = 0;
            DataManager.Instance.maca = 0;
            DataManager.Instance.pancake = 0;
            DataManager.Instance.straw = 0;
            DataManager.Instance.twist = 0;

            for (int i = 0; i < 6; i++)
            {
                DataManager.Instance.straw_DialogeKeywordsOpen[i] = false;
                DataManager.Instance.cake_DialogeKeywordsOpen[i] = false;
                DataManager.Instance.crois_DialogeKeywordsOpen[i] = false;
                DataManager.Instance.maca_DialogeKeywordsOpen[i] = false;
                DataManager.Instance.jelly_DialogeKeywordsOpen[i] = false;
                DataManager.Instance.jellyjelly_DialogeKeywordsOpen[i] = false;
                DataManager.Instance.jam_DialogeKeywordsOpen[i] = false;
                DataManager.Instance.hodu_DialogeKeywordsOpen[i] = false;
                DataManager.Instance.twist_DialogeKeywordsOpen[i] = false;
                DataManager.Instance.choco_DialogeKeywordsOpen[i] = false;
                DataManager.Instance.choco_DialogeKeywordsOpen[i] = false;
            }

            DataManager.Instance.strawRoomKey = false;
            DataManager.Instance.masterKey = false;

          //  for(int i=0; i<)

        }

        private void SetActiveTrue()
        {
            steps[++currentStep].SetActive(true);
            GameModel.Instance.EffectManager.FadeIn(0.2f);
            if (currentStep == 1) // 말하는 부분
            {
                Invoke("InvokeOpening", 1f);
            }
        }

        private void SetActiveFalse()
        {
            steps[currentStep].SetActive(false);
        }

        private void InvokeOpening()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("opening"));
            GameModel.Instance.EventManager.AddBlockingEvent(new ActionEvent(() => { Next(); }));
        }

        public void NextScene()
        {
            SceneManager.UnloadSceneAsync("Opening");

            SceneManager.LoadScene("Player", LoadSceneMode.Additive);

            GameModel.Instance.Hp.hp = 300f;

            //데모
            // GameModel.Instance.EffectManager.Fade();
            GameModel.Instance.EffectManager.FadeIn();
            SceneManager.LoadScene("Map1_1", LoadSceneMode.Additive);
            GameModel.Instance.StateManager.SetState(new PlayingState());
        }

        public void SetPlayerName()
        {
            if (playerName.text.Equals(""))
            {
                // 입력이 제대로 되지 않은 경우
                return;
            }
            else
            {
                DataManager.Instance.PlayerName = playerName.text;
                Invoke("NextScene", 2f);

                GameModel.Instance.AudioManager.StopBackgroundAudio();
                Next();
                Debug.Log(DataManager.Instance.PlayerName);
            }
        }

        private void Start()
        {
            GameModel.Instance.StateManager.SetState(new OpeningState());
            GameModel.Instance.AudioManager.ChangeBackgroundAudio("인트로");
        }

        private void Update()
        {
            //esc를 눌렀을 때 
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Debug.Log("esc누름");
                if (endingDetail.activeSelf == true) //엔딩 디테일 오브젝트가 setActive(true)인 경우
                {
                    endingDetail.SetActive(false);
                    Debug.Log("엔딩 디테일 켜진상태에서 esc");
                }
                else
                {
                    endingPanel.SetActive(false);
                    Debug.Log("엔딩 디테일 꺼진 상태에서 esc");
                }
            }
        }


        //엔딩 이미지 로드
        private void Load_Ending()
        {
            //i번째 앤딩이 true인지 확인
            for (int i = 0; i < 6; i++)
            {
                if (DataManager.Instance.ending_[i] == true)
                {
                    //만약 true이면

                    //endings[i].SetActive(true);
                    string Image_name = "middleEnding_image_";

                    endings[i].GetComponent<Image>().sprite = ResourceLoader.LoadSprite(Image_name + (i + 1));

                    endings[i].GetComponent<Button>().interactable = true;
                }
                else
                {
                    endings[i].GetComponent<Button>().interactable = false;
                }

            }
            if (DataManager.Instance.ending_happyEnding[0] == true) //해피엔딩
            {
                finalEnding[0].GetComponent<Image>().sprite = ResourceLoader.LoadSprite("totallyHappyEnding");
                finalEnding[0].GetComponent<Button>().interactable = true;
            }
            else
            {
                finalEnding[0].GetComponent<Button>().interactable = false;
            }
            if (DataManager.Instance.ending_happyEnding[1] == true) //배드엔딩
            {
                finalEnding[1].GetComponent<Image>().sprite = ResourceLoader.LoadSprite("배드엔딩");
                finalEnding[1].GetComponent<Button>().interactable = true;
            }
            else
            {
                finalEnding[1].GetComponent<Button>().interactable = false;
            }


        }
        
        //엔딩 이미지 클릭
        public void Click_ending_Detail()
        {
               
            GameObject clickButton = EventSystem.current.currentSelectedGameObject;
            
            endingDetail.GetComponent<Image>().sprite = ResourceLoader.LoadSprite(clickButton.name);


            endingDetail.SetActive(true);            

        }
        //엔딩이미지 나가기 
        public void Click_ending_Detail_exit()
        {
            endingDetail.SetActive(false);

        }



        //엔딩 버튼 클릭
        public void Click_Ending()
        {
            endingPanel.SetActive(true);  //엔딩패널 활성화
            GameModel.Instance.DataController.Load_Ending();
            Load_Ending();
        }

        //엔딩 나가기 버튼
        public void Exit_Ending_button()
        {
            endingPanel.SetActive(false); //엔딩패널 비활성화
        }

        //엔딩 나가기 버튼 
        public void Click_Exit_Ending()
        {
            endingPanel.SetActive(false);
        }


        public void ClickInfo()
        {
            info.SetActive(true);
        }

        public void ClickInfoEscape()
        {
            info.SetActive(false);
        }

        public void ExitButton()
        {
            Application.Quit();
            Debug.Log("게임종료");
        }

        public void Click_Load()
        {
            GameModel.Instance.DataController.LoadData(); //데이터 로드 
            load_LoadScene();
        }

        private void load_LoadScene() //로드버튼을 크릭했을 때 씬이동
        {
            // 엔딩 파일이 있으면
            if (Directory.Exists(Application.dataPath + "/Save/" + "/SaveFile"))
            {
                Debug.Log("저장된 파일을 불러옴");
                SceneManager.UnloadSceneAsync("Opening");

                SceneManager.LoadScene("Player", LoadSceneMode.Additive);

                //date+1에 해당하는 씬 이동 
                GameModel.Instance.EffectManager.FadeIn();

                string LoadDate_Scene = "Day" + DataManager.Instance.date + 1 + "_event";  //date 아침 이벤트 씬으로 연결되어야함 
                SceneManager.LoadScene(LoadDate_Scene, LoadSceneMode.Additive);


                GameModel.Instance.StateManager.SetState(new PlayingState());

            }
            else // 저장된 파일이 없으면
            {
                Debug.Log("저장된 파일 없음");
            }

            

        }

        


    }
}