using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay {
    public class DateManager : MonoBehaviour
    {
        private int day = 1;

        public void AddDay(int number)
        {
            day += number;
            Render();
        }

        private void Render()
        {
            GameModel.Instance.Date.SetDate(day);
        }
    }
}
