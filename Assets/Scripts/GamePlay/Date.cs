using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using HappyBread.Core;
using HappyBread.ETC;



namespace HappyBread.GamePlay
{
    public class Date : MonoBehaviour
    {
        public Text text;
        public int date;

        private readonly int MAX_DATE = 7;

        private void Awake()
        {
            date = DataManager.Instance.date;
        }

        public int Current
        {
            get { return date; }
        }

        public void SetDate(int number)
        {
            if (number < 0 || number > MAX_DATE)
            {
                Debug.Log("불가능한 날짜입니다.");
                return;
            }

            this.date = number;
            Render();
        }

        public void AddDay(int number)
        {
            if (number + this.date > MAX_DATE)
            {
                Debug.Log("불가능한 날짜입니다.");
                //불러오지 않게하기 
                return;
            }
            DataManager.Instance.date += number;
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

}
