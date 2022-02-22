using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HappyBread.GamePlay.GameState;
using UnityEngine.SceneManagement;

namespace HappyBread.GamePlay
{
    public class CallBtn : MonoBehaviour
    {

        public void Appear()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
        public void ClickCall()
        {
            GameModel.Instance.DataController.saveData.evidence_Sprite.Clear();


            SceneManager.UnloadSceneAsync($"Map{DataManager.Instance.date}_1");
            GameModel.Instance.EventManager.AddBlockingEvent(new NextDayDialogueEvent("Day4_event"));

        }
    }

}

