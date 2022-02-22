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

        //스페이스바 두번 방지용
        public bool spaceBar = false;
        public float controll_space = 0f;
        //로드 여러번 방지용
        public bool Loading = false;

        public void Next()
        {
            GameModel.Instance.EffectManager.FadeIn(0.2f);

            //데이터 초기화 
            controll_space = 1.5f;
            //  Invoke("SetActiveFalse", 1.1f);
            SetActiveFalse();
            if (currentStep + 1 >= steps.Length) // 다음 씬으로 넘어간다.
            {
                DataInitalization();
                //Invoke("NextScene", 2f);
                GameModel.Instance.AudioManager.ChangeBackgroundAudio("Dance_Of_The_Sugar_Plum_Fairies");
                GameModel.Instance.AudioManager.PlayBackgroundAudio();
                return;
            }


            Invoke("SetActiveTrue", 0.5f);
        }

        //
 
        private void DataInitalization()
        {
            Debug.Log("데이터 초기화");
            
            DataManager.Instance.Day3_freezerKey = false;
            DataManager.Instance.day2Crois_lie = false;
            DataManager.Instance.floor = 1;//1층
            //start눌렀을 때 데이터 초기화를 위함! 
            DataManager.Instance.date = 1;
            GameModel.Instance.Date.SetDate(1);
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
            DataManager.Instance.stopVoice = false;
            GameModel.Instance.latelyEvidence.removeEvidence(); //최근습득증거 초기화

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
            Debug.Log("SAT");

            if (currentStep == 0)
            {
                //spaceBar = true;
                
                steps[++currentStep].SetActive(true);
               // GameModel.Instance.EffectManager.FadeIn(0.2f);
                // Debug.Log("SetActive True : currentStep  => "+ currentStep);
            }
            else if (currentStep == 1)
            {
                // spaceBar = true;
              //  GameModel.Instance.EffectManager.FadeIn(0.2f);
                //GameModel.Instance.EffectManager.Fade();//
                steps[++currentStep].SetActive(true);
                // GameModel.Instance.EffectManager.FadeIn(0.2f);
            }
            else if (currentStep == 2) // 말하는 부분
            {
               // currentStep++;
               // GameModel.Instance.EffectManager.FadeIn(0.2f);
                // GameModel.Instance.EffectManager.FadeIn(0.2f);
               
                //spaceBar = false;
                Invoke("InvokeOpening", 1f);
                //  Debug.Log("SetActive True : currentStep  => " + currentStep);
            }
            else
            {
                return;
            }

        }

        private void SetActiveFalse()
        {

            //Debug.Log("SetActive False : currentStep  => " + currentStep);
            if (currentStep == 0)
            {
               // GameModel.Instance.EffectManager.FadeOut();
                steps[currentStep].SetActive(false);
            }
            else if (currentStep == 1)
            {
              //  GameModel.Instance.EffectManager.FadeOut();
                steps[currentStep].SetActive(false);
                spaceBar = false;
            }
            else if(currentStep ==2)
            {
                return;
               // steps[currentStep].SetActive(false);
            }
           
        }

        private void InvokeOpening()
        {

            currentStep++;
            //spaceBar = false;
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("opening"));
            GameModel.Instance.EventManager.AddBlockingEvent(new ActionEvent(() => { steps[3].SetActive(true); steps[2].SetActive(false); }));
            GameModel.Instance.EventManager.AddBlockingEvent(new ActionEvent(() => { Next();  }));

            
        }

        public void NextScene()
        {
            SceneManager.UnloadSceneAsync("Opening");

            SceneManager.LoadScene("Player", LoadSceneMode.Additive);

            //GameModel.Instance.Hp.hp = 300f;

            //데모
            // GameModel.Instance.EffectManager.Fade();
            GameModel.Instance.EffectManager.FadeIn();
            SceneManager.LoadScene("IntroAnim", LoadSceneMode.Additive);
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
                Invoke("NextScene", 1f);

                GameModel.Instance.AudioManager.StopBackgroundAudio();
                Next();
                Debug.Log(DataManager.Instance.PlayerName);
            }
        }

        private void Start()
        {
            GameModel.Instance.StateManager.SetState(new OpeningState());
            GameModel.Instance.AudioManager.ChangeBackgroundAudio("인트로");
            //엔딩 로드 
            GameModel.Instance.DataController.Load_Ending();
            Loading = false;
            spaceBar = false;
        }

        private void Update()
        {
            //esc를 눌렀을 때 
            if (Input.GetKeyDown(KeyCode.Escape))
            {
              //  Debug.Log("esc누름");
                if (endingDetail.activeSelf == true) //엔딩 디테일 오브젝트가 setActive(true)인 경우
                {
                    endingDetail.SetActive(false);
                  //  Debug.Log("엔딩 디테일 켜진상태에서 esc");
                }
                else
                {
                    endingPanel.SetActive(false);
                //    Debug.Log("엔딩 디테일 꺼진 상태에서 esc");
                }

            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                if (currentStep > 0 &&currentStep<3)
                {
                    //if (spaceBar == true)
                    //{
                    //    Next();
                    //}
                    if (controll_space <= 0)
                    {
                        Next();
                    }
                    
                        
                                     
                }
           
            }

            if (controll_space > 0)
            {
                controll_space = controll_space - Time.deltaTime;           
            }
            if (controll_space <0)
            {
                controll_space = 0;
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
                finalEnding[0].GetComponent<Image>().sprite = ResourceLoader.LoadSprite("해피엔딩");
                finalEnding[0].GetComponent<Button>().interactable = true;
            }
            else
            {
                finalEnding[0].GetComponent<Button>().interactable = false;
            }
            if (DataManager.Instance.ending_happyEnding[1] == true) //배드엔딩
            {
              //Debug.Log("배드엔딩 이미지 보여줭");
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
            // 최근습득증거 날리기 
            GameModel.Instance.latelyEvidence.removeEvidence();
            if (Loading == false)
            {
                DataManager.Instance.evidences.Clear();//데이터메니저에 있는 증거 초기화시키기 위함 
                GameModel.Instance.DataController.LoadData(); //데이터 로드 
                Loading = true;
                Invoke("load_LoadScene", 1f);
            }

            // load_LoadScene();
        }

        private void load_LoadScene() //로드버튼을 크릭했을 때 씬이동
        {
          //Debug.Log("로드씬");
            Loading = false;

            // 엔딩 파일이 있으면
            if (File.Exists(Application.dataPath + "/Save/" + "/SaveFile.txt"))
            {
              //  Debug.Log("저장된 파일을 불러옴");
                SceneManager.UnloadSceneAsync("Opening");

                DataManager.Instance.floor = 1;//1층

                SceneManager.LoadScene("Player", LoadSceneMode.Additive);

                //date+1에 해당하는 씬 이동 
                GameModel.Instance.EffectManager.FadeIn();

                if (DataManager.Instance.date == 5) //추리하기때 죽음
                {
                    DataManager.Instance.date = 4;
                    GameModel.Instance.Date.SetDate(4);
                    SceneManager.LoadScene("Day4_event", LoadSceneMode.Additive);
                }
                else if (DataManager.Instance.date == 1)
                {
                    DataManager.Instance.date = 1;
                    GameModel.Instance.Date.SetDate(1);
                    SceneManager.LoadScene("IntroAnim", LoadSceneMode.Additive);
                }
                else if (DataManager.Instance.date == 2)
                {
                    DataManager.Instance.date = 2;
                    GameModel.Instance.Date.SetDate(2);
                    SceneManager.LoadScene("Day2_event", LoadSceneMode.Additive);
                }
                else if (DataManager.Instance.date == 3)
                {
                    DataManager.Instance.date = 3;
                    GameModel.Instance.Date.SetDate(3);
                    SceneManager.LoadScene("Day3_event", LoadSceneMode.Additive);
                }
                else if (DataManager.Instance.date == 4)
                {
                    DataManager.Instance.date = 4;
                    GameModel.Instance.Date.SetDate(4);
                    SceneManager.LoadScene("Day4_event", LoadSceneMode.Additive);
                }


                GameModel.Instance.AudioManager.ChangeBackgroundAudio("죽는씬음악");

                GameModel.Instance.StateManager.SetState(new PlayingState());

            }
            else // 저장된 파일이 없으면
            {
                Debug.Log("저장된 파일 없음");
            }

            

        }

        


    }
}