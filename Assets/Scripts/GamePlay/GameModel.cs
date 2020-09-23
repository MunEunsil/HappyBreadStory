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
                if (_instance == null)
                {
                    _instance = GameObject.Find("GameModel").GetComponent<GameModel>();
                }
                return _instance;
            }
        }
        [SerializeField]
        private InputManager inputManager;
        [SerializeField]
        private EventManager eventManager;
        [SerializeField]
        private UIManager uiManager;
        [SerializeField]
        private EffectManager effectManager;
        [SerializeField]
        private FloorManager floorManager;
        [SerializeField]
        private CaseDiary caseDiary;
        [SerializeField]
        private QuestionBox questionBox;
        [SerializeField]
        private Dialogue dialogue;
        [SerializeField]
        private Player player;
        [SerializeField]
        private Hp hp;
        [SerializeField]
        private StateManager stateManager;
        [SerializeField]
        private Date date;
        [SerializeField]
        private Background background;
        [SerializeField]
        private Fade fade;

        public InputManager InputManager
        {
            get
            {
                if(inputManager == null)
                {
                    inputManager = GameObject.FindObjectOfType<InputManager>();
                }
                return inputManager;
            }
        }
        public EventManager EventManager
        {
            get
            {
                if (eventManager == null)
                {
                    eventManager = GameObject.FindObjectOfType<EventManager>();
                }
                return eventManager;
            }
        }
        public FloorManager FloorManager
        {
            get
            {
                if (floorManager == null)
                {
                    floorManager = GameObject.FindObjectOfType<FloorManager>();
                }
                return floorManager;
            }
        }
        public CaseDiary CaseDiary
        {
            get
            {
                if (caseDiary == null)
                {
                    caseDiary = GameObject.FindObjectOfType<CaseDiary>();
                }
                return caseDiary;
            }
        }

        public QuestionBox QuestionBox
        {
            get
            {
                if (questionBox == null)
                {
                    questionBox = GameObject.FindObjectOfType<QuestionBox>();
                }
                return questionBox;
            }
        }

        public Dialogue Dialogue
        {
            get
            {
                if (dialogue == null)
                {
                    dialogue = GameObject.FindObjectOfType<Dialogue>();
                }
                return dialogue;
            }
        }
        public Player Player
        {
            get
            {
                if (player == null)
                {
                    player = GameObject.FindObjectOfType<Player>();
                }
                return player;
            }
        }
        public Hp Hp
        {
            get
            {
                if (hp == null)
                {
                    hp = GameObject.FindObjectOfType<Hp>();
                }
                return hp;
            }
        }

        public Date Date
        {
            get
            {
                if (date == null)
                {
                    date = GameObject.FindObjectOfType<Date>();
                }
                return date;
            }
        }

        public Background Background
        {
            get
            {
                if (background == null)
                {
                    background = GameObject.FindObjectOfType<Background>();
                }
                return background;
            }
        }

        public Fade Fade
        {
            get
            {
                if (fade == null)
                {
                    fade = GameObject.FindObjectOfType<Fade>();
                }
                return fade;
            }
        }

        public UIManager UIManager
        {
            get
            {
                if (uiManager == null)
                {
                    uiManager = GameObject.FindObjectOfType<UIManager>();
                }
                return uiManager;
            }
        }

        public StateManager StateManager
        {
            get
            {
                if (stateManager == null)
                {
                    stateManager = GameObject.FindObjectOfType<StateManager>();
                }
                return stateManager;
            }
        }

        public EffectManager EffectManager
        {
            get
            {
                if (effectManager == null)
                {
                    effectManager = GameObject.FindObjectOfType<EffectManager>();
                }
                return effectManager;
            }
        }

        private static GameModel _instance = null;

        private void Awake()
        {
            if(_instance == null)
            {
                _instance = this;
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}