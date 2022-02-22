using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class EffectManager : MonoBehaviour
    {
        /// <summary>
        /// FadeOut이 끝난 후 FadeIn을 합니다.
        /// </summary>
        public void Fade()
        {
            FadeOut();
            FadeIn(1.5f);
        }

        /// <summary>
        /// 효과를 수행하기 전에 IdleTime 만큼 기다립니다.
        /// </summary>
        /// <param name="idleTime">기다리는 시간</param>
        public void FadeIn(float idleTime)
        {
            Invoke("FadeIn", idleTime);
        }

        /// <summary>
        /// FadeIn을 시작합니다.
        /// </summary>
        public void FadeIn()
        {
            GameModel.Instance.Fade.Appear();
            GameModel.Instance.Fade.StartFadeIn();
        }

        /// <summary>
        /// 효과를 수행하기 전에 IdleTime 만큼 기다립니다.
        /// </summary>
        /// <param name="idleTime">기다리는 시간</param>
        public void FadeOut(float idleTime)
        {
            Invoke("FadeOut", idleTime);
        }

        /// <summary>
        /// FadeOut을 시작합니다.
        /// </summary>
        public void FadeOut()
        {
        
            GameModel.Instance.Fade.Appear();
            GameModel.Instance.Fade.StartFadeOut();
        }
    }
}
