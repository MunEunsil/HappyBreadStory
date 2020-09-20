using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Date : MonoBehaviour
{
    public Text text;

    private int date = 1;

    public void SetDate(int number)
    {
        if(number < 0)
        {
            return;
        }
        this.date = number;
        Render();
    }

    public void AddDay(int number)
    {
        this.date += number;
        Render();
    }

    public void Appear()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    private void Render()
    {
        text.text = $"Day\n{this.date}";
    }
}
