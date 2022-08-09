using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace HappyBread.GamePlay
{
    /// <summary>
    /// 질문에 대한 설정을 할 수 있는 클래스.
    /// </summary>
    public class Question : MonoBehaviour
    {
        public Text text;
        public Image background;

       // private float backgroundHeight = 50f;
      //  private float textPadding = 10f;

        public void SetText(string text)
        {
            this.text.text = text;
            AdjustSize();
        }

        private void AdjustSize()
        {
            if (text.preferredWidth > background.rectTransform.rect.width ) //+textPadding
            {
                //background.rectTransform.sizeDelta = new Vector2(text.preferredWidth + textPadding, backgroundHeight);
                text.fontSize = 28;
            }
        }

        public void SetBackgroundAlpha(float value)
        {
            background.color = new Color(background.color.r, background.color.g, background.color.b, value);
        }
    }
}
