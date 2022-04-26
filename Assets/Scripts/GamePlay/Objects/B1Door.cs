using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HappyBread.GamePlay
{
    public class B1Door : MonoBehaviour
    {
        /// <summary>
        /// 지하1층에 문에 충돌하면 페이드효과
        /// </summary>
        // Start is called before the first frame update


        private void Start()
        {
            DataManager.Instance.inOven = false;
            DataManager.Instance.inPriz = false;
            DataManager.Instance.stopTimer = true;
        }

        public float timer = 0f;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                GameModel.Instance.AudioManager.D_Audio("door");
                GameModel.Instance.EffectManager.Fade();
                if (this.gameObject.name == "ovenDoor")
                {
                    if (DataManager.Instance.inOven == true)
                    {
                        DataManager.Instance.inOven = false;
                        DataManager.Instance.stopTimer = true;
                    }
                    else
                    {
                        DataManager.Instance.inOven = true;
                        DataManager.Instance.stopTimer = false;
                    }

                }
                else if (this.gameObject.name == "freezerDoor")
                {
                    if (DataManager.Instance.inPriz == true)
                    {
                        DataManager.Instance.inPriz = false;
                    }
                    else
                    {
                        DataManager.Instance.inPriz = true;
                        DataManager.Instance.stopTimer = false;
                    }
                }

            }


        }
        public void timerStart()
        {
            DataManager.Instance.stopTimer = false; // 타이머 시작 
        }

        public void timerStop()
        {
            DataManager.Instance.stopTimer = true; // 타이머 멈춤
        }



        private void Update()
        {
            if (DataManager.Instance.inOven == true)
            {
                if (DataManager.Instance.stopTimer == false)
                {
                    timer += Time.deltaTime;
                    if (timer > 60)
                    {
                        GameModel.Instance.MiddleEnding.startOvenEnding();
                    }
                }               
            }
            if (DataManager.Instance.inPriz == true)
            {
                if (DataManager.Instance.stopTimer == false)
                {
                    timer += Time.deltaTime;
                    if (timer > 60)
                    {
                        GameModel.Instance.MiddleEnding.startFreezerEnding();
                    }
                }

            }

        }

    }
}
