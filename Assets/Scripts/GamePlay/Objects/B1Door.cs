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
        public bool inOven = false;
        public bool inPriz = false;

        private void Start()
        {
            inOven = false;
            inPriz = false;
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
                    if (inOven == true)
                    {
                        inOven = false;
                    }
                    else
                    {
                        inOven = true;

                    }

                }
                else if (this.gameObject.name == "freezerDoor")
                {
                    if (inPriz == true)
                    {
                        inPriz = false;
                    }
                    else
                    {
                        inPriz = true;
                    }
                }

            }


        }
        private void timerStart()
        {
            timer += Time.deltaTime;
        }
        private void Update()
        {
            if (inOven == true)
            {
                timer += Time.deltaTime;
                if (timer > 60)
                {
                    GameModel.Instance.MiddleEnding.startOvenEnding();
                }
            }
            if (inPriz == true)
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
