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

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {

                GameModel.Instance.EffectManager.Fade();

            }


        }

    }
}
