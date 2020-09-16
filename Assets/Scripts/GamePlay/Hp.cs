using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HappyBread.GamePlay
{
    /// <summary>
    /// Hp 값을 제어하고 관리하는 클래스.
    /// </summary>
    public class Hp : MonoBehaviour
    {
        public Image fill;
        private float maxHp = 100.0f;
        private float hp;

        public void Add(float value)
        {            
            hp += value;
            fill.fillAmount = hp / maxHp;
        }

        public void Set(float value)
        {
            hp = value;
            fill.fillAmount = hp / maxHp;
        }

        private void Awake()
        {
            hp = maxHp;
        }
    }
}
