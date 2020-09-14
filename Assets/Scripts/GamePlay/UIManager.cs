using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class UIManager : MonoBehaviour
    {
        public GameObject hpUI;

        public void SetActiveUIs(bool isOn)
        {
            hpUI.SetActive(isOn);
        }
    }
}
