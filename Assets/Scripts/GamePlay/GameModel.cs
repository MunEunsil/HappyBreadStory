using HappyBread.GamePlay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.Core
{
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
        public DialogueManager dialogueManager;
        public InputManager inputManager;
        public CaseDiary caseDiary;
        public HpControl hpControl;
        public QuestionManager questionManager;

        private static GameModel instance;
    }
}