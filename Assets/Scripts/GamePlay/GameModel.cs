using HappyBread.GamePlay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    /// <summary>
    /// 게임 내의 각종 객체를 저장하는 클래스.
    /// </summary>
    public class GameModel : MonoBehaviour
    {
        public static GameModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = GameObject.Find("GameModel").GetComponent<GameModel>();
                }
                return instance;
            }
        }

        public InputManager inputManager;
        public EventManager eventManager;
        public CaseDiary caseDiary;
        public QuestionBox questionBox;
        public Dialogue dialogue;
        public Player player;
        public Hp hp;

        private static GameModel instance;
    }
}