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
        public void ClockAppear()
        {
            GameModel.Instance.Clock.Appear();
        }
        public void ClockHide()
        {
            GameModel.Instance.Clock.Hide();
        }
        public void CaseDiaryBtnAppear()
        {
            GameModel.Instance.CaseDiaryBtn.Appear();
        }
        public void CaseDiaryBtnHide()
        {
            GameModel.Instance.CaseDiaryBtn.Hide();
        }

        public void DateAppear()
        {
            GameModel.Instance.Date.Appear();
        }

        public void DateHide()
        {
            GameModel.Instance.Date.Hide();
        }
        public void CallBtnAppear()
        {
            GameModel.Instance.CallBtn.Appear();
        }
        public void CallBtnHide()
        {
            GameModel.Instance.CallBtn.Hide();
        }
        public void SettingBtnAppear()
        {
            GameModel.Instance.SettingBtn.Appear();
        }
        public void SettingBtnHide()
        {
            GameModel.Instance.SettingBtn.Hide();
        }

        /// <summary>
        /// Basic == Hp, Date, Clock, SettingBtn,CaseDiaryBtn,
        /// </summary>
        public void BasicUIAppear()
        {
            HpAppear();
            DateAppear();
            ClockAppear();
            CaseDiaryBtnAppear();
            CallBtnAppear();
            SettingBtnAppear();
          

        }

        /// <summary>
        /// Basic == Hp, Date
        /// </summary>
        public void BasicUIHide()
        {
            HpHide();
            DateHide();
            ClockHide();
            CaseDiaryBtnHide();
            CallBtnHide();
            SettingBtnHide();
        }
    }
}
