using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Date : MonoBehaviour
{
    public Text text;
    private int date = 1;
    private readonly int MAX_DATE = 6;
    public int Current
    {
        get { return date; }
    }

    public void SetDate(int number)
    {
        if(number < 0 || number > MAX_DATE)
        {
            Debug.Log("불가능한 날짜입니다.");
            return;
        }

        this.date = number;
        Render();
    }

    public void AddDay(int number)
    {
        if(number + this.date > MAX_DATE)
        {
            Debug.Log("불가능한 날짜입니다.");
            return;
        }

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
