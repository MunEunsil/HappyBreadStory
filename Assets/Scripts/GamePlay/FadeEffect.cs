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
        public string effect;
        public float speed;

        private float start, end;

        private void Start()
        {
            StartCoroutine(effect);
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

            SceneManager.UnloadSceneAsync("FadeIn");
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
            SceneManager.UnloadSceneAsync("FadeOut");
        }
    }
}