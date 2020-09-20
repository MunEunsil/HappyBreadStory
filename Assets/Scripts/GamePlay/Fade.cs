using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace HappyBread.GamePlay
{
    public class Fade : MonoBehaviour
    {
        public Image target;
        public float speed;
        private float start, end;
        private Coroutine coroutine;

        public void StartFadeIn()
        {
            if (coroutine != null)
            {
                StopCoroutine(coroutine);
            }
            coroutine = StartCoroutine(FadeIn());
        }

        public void StartFadeOut()
        {
            if (coroutine != null)
            {
                StopCoroutine(coroutine);
            }
            coroutine = StartCoroutine(FadeOut());
        }

        public void Appear()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
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
            Hide();
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