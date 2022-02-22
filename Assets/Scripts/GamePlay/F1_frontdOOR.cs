using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HappyBread.GamePlay
{
    public class F1_frontdOOR : MonoBehaviour
    {


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                GameModel.Instance.AudioManager.D_Audio("door");
                GameModel.Instance.EffectManager.Fade();


            }

        }
    }
}