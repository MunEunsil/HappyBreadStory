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

        public void DateAppear()
        {
            GameModel.Instance.Date.Appear();
        }

        public void DateHide()
        {
            GameModel.Instance.Date.Hide();
        }

        /// <summary>
        /// Basic == Hp, Date
        /// </summary>
        public void BasicUIAppear()
        {
            HpAppear();
            DateAppear();
        }

        /// <summary>
        /// Basic == Hp, Date
        /// </summary>
        public void BasicUIHide()
        {
            HpHide();
            DateHide();
        }
    }
}
