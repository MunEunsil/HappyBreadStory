using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Date : MonoBehaviour
{
    public Text text;

    private string day;

    public void SetDate(int day)
    {
        if(day < 0)
        {
            return;
        }
        this.day = day.ToString();
        text.text = $"Day\n{this.day}";
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
