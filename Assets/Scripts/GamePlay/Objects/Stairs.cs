using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class Stairs : MonoBehaviour
    {
        public int from;
        //public int to;
        public GameObject exitB1;
        public GameObject exitF1;
        public GameObject exitF2;
        public GameObject exitF3;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            

            from = DataManager.Instance.floor;

            if (collision.CompareTag("Player"))
            {

                GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("MoveStair"));
                DataManager.Instance.stair = true;

                //  GameModel.Instance.FloorManager.ChangeFloor(from, to, exit.transform.position);

            }
        }
    }
}
