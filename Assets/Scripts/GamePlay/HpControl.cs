using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HappyBread.GamePlay
{
    public class HpControl : MonoBehaviour
    {
        public Image fill;
        private float maxHp = 100.0f;
        private float hp;

        public void Add(float value)
        {            
            hp += value;
            fill.fillAmount = hp / maxHp;
        }

        private void Awake()
        {
            hp = maxHp;
        }
    }
}
