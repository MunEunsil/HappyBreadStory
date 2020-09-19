using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    /// <summary>
    /// UI를 관리하는 매니저 클래스
    /// </summary>
    public class UIManager : MonoBehaviour
    {
        public void HpAppear()
        {
            GameModel.Instance.Hp.Appear();
        }

        public void HpHide()
        {
            GameModel.Instance.Hp.Hide();
        }
    }
}
