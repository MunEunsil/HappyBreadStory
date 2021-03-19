using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class Stairs : MonoBehaviour
    {
        public int from;
        public int to;
        public GameObject exit;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.CompareTag("Player"))
            {
                GameModel.Instance.FloorManager.ChangeFloor(from, to, exit.transform.position);
               
            }
        }
    }
}
