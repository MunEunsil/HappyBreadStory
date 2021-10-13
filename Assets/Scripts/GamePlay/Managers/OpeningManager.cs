using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace HappyBread.GamePlay
{
    public class OpeningManager : MonoBehaviour
    {
        public GameObject[] steps;
        public int currentStep;
        public Text playerName;

        //인포 오브젝트 
        public GameObject info;



        public void Next()
        {
            GameModel.Instance.EffectManager.FadeOut();
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
           // SceneManager.LoadScene("Map1_1",LoadSceneMode.Additive);
            SceneManager.LoadScene("Player", LoadSceneMode.Additive);
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
            }
        }

        private void Start()
        {
            GameModel.Instance.StateManager.SetState(new OpeningState());
        }

        public void ClickInfo()
        {
            info.SetActive(true);
        }

        public void ClickInfoEscape()
        {
            info.SetActive(false);
        }


    }
}