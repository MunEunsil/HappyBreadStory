using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HappyBread.GamePlay
{
    public class Background : MonoBehaviour
    {
        public Image background;

        public void Change(Sprite sprite)
        {
            background.sprite = sprite;
        }

        public void Appear()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}