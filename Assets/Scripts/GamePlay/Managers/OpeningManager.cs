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

        public void Next()
        {
            SceneManager.LoadSceneAsync("FadeEffect", LoadSceneMode.Additive);
            Invoke("SetActiveFalse", 2f);

            if (currentStep + 1 >= steps.Length) // 다음 씬으로 넘어간다.
            {
                Invoke("NextScene", 2f);
                return;
            }

            Invoke("SetActiveTrue", 2f);
        }

        private void SetActiveTrue()
        {
            steps[++currentStep].SetActive(true);
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

        private void NextScene()
        {
            SceneManager.LoadScene("Main", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("Opening");
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
                Next();
            }
        }

        private void Start()
        {
            GameModel.Instance.StateManager.SetState(new OpeningState());
        }
    }
}