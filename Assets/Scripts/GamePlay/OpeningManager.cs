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
            SceneManager.LoadSceneAsync("FadeIn", LoadSceneMode.Additive);
            steps[currentStep].SetActive(false);

            if (currentStep + 1 >= steps.Length)
            {
                SceneManager.LoadScene("MainScene", LoadSceneMode.Additive);
                SceneManager.UnloadSceneAsync("OpeningScene");
                GameModel.Instance.InputManager.SetState(InputManager.State.PlayerControl);
                return;
            }

            steps[++currentStep].SetActive(true);

            if(currentStep == 1) // 말하는 부분
            {
                Invoke("InvokeOpening", 0.3f);
            }
        }

        private void InvokeOpening()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("opening"));
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