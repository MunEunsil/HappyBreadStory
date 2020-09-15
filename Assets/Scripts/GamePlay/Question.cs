using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    public Text text;
    public Image background;

    private float backgroundHeight = 50f;
    private float textPadding = 10f;

    public void SetText(string text)
    {
        this.text.text = text;
        AdjustSize();
    }

    private void AdjustSize()
    {
        if (text.preferredWidth > background.rectTransform.rect.width + textPadding)
        {
            background.rectTransform.sizeDelta = new Vector2(text.preferredWidth + textPadding, backgroundHeight);
        }
    }

    public void SetBackgroundAlpha(float value)
    {
        background.color = new Color(background.color.r, background.color.g, background.color.b, value);
    }
}
