using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HappyBread.GamePlay
{
    public class exitToOpeningBtn : MonoBehaviour
    {
        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void Appear()
        {
            gameObject.SetActive(true);
        }
        public void clickExitToOpeningBtin()
        {
            // 은실 - 수정(22.06.30 npc와 대화중 나가는 문제 있음 해결하기)

            // NextCommand = KeyCode.None;
            DataManager.Instance.evidences.Clear(); //증거 날리기 

            SceneManager.LoadScene("Opening", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("Player");
            SceneManager.UnloadSceneAsync($"Map{DataManager.Instance.date}_1");

            GameModel.Instance.AudioManager.ChangeBackgroundAudio("오프닝");

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
        }
    }
}