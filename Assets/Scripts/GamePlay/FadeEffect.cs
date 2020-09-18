using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace HappyBread.GamePlay
{
    public class FadeEffect : MonoBehaviour
    {
        public Image target;
        public float speed;
        public float aliveTime; // Fade out이 시작한 뒤로부터 되고 얼마나 기다리는 지

        private float start, end;

        private void Start()
        {
            StartCoroutine("FadeOut");
            Invoke("StartFadeIn", aliveTime);
        }

        private void StartFadeIn()
        {
            StopCoroutine("FadeOut");
            StartCoroutine("FadeIn");
        }

        private IEnumerator FadeIn()
        {
            start = 255f;
            end = 0f;
            while (start != end)
            {
                target.color = new Color(0f, 0f, 0f, start / 255f);
                start--;
                yield return new WaitForSeconds(speed);
            }

            SceneManager.UnloadSceneAsync("FadeEffect");
        }

        private IEnumerator FadeOut()
        {
            start = 0f;
            end = 255f;
            while (start != end)
            {
                target.color = new Color(0f, 0f, 0f, start / 255f);
                start++;
                yield return new WaitForSeconds(speed);
            }
        }
    }
}