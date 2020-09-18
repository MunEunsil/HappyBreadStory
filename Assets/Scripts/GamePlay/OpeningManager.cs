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

            if (currentStep + 1 >= steps.Length)
            {
                Invoke("NextScene", 2f);
                return;
            }

            currentStep++;
            Invoke("SetActiveTrue", 2f);

            if (currentStep == 1) // 말하는 부분
            {
                Invoke("InvokeOpening", 3f);
            }
        }

        private void SetActiveTrue()
        {
            steps[currentStep].SetActive(true);
        }

        private void SetActiveFalse()
        {
            steps[currentStep].SetActive(false);
        }

        private void InvokeOpening()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("opening"));
        }

        private void NextScene()
        {
            SceneManager.LoadScene("Main", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("Opening");
            GameModel.Instance.InputManager.SetState(InputManager.State.PlayerControl);
        }

        public void SetPlayerName()
        {
            if (playerName.Equals(""))
            {
                return;
            }
            else
            {
                DataManager.Instance.PlayerName = playerName.text;
                Next();
            }
        }
    }
}