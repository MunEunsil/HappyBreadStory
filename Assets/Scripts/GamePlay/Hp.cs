﻿using System.Collections;
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
        private float maxHp = 300.0f;
        public float hp;

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

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void Appear()
        {
            gameObject.SetActive(true);
        }

        private void Awake()
        {
            hp = maxHp;
        }

    }
}
