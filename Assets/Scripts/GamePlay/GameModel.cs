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
        private AudioManager audioManager;
        [SerializeField]
        private UIManager uiManager;
        [SerializeField]
        private EffectManager effectManager;
        [SerializeField]
        private FloorManager floorManager;
        [SerializeField]
        private MapManager mapManager;
        [SerializeField]
        private Clock clock;       
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
        private CaseDiaryBtn caseDiaryBtn;
        [SerializeField]
        private StateManager stateManager;
        [SerializeField]
        private Date date;
        [SerializeField]
        private Background background;
        [SerializeField]
        private Fade fade;
        [SerializeField]
        private CallBtn callBtn;
        [SerializeField]
        private SettingBtn settingBtn;
        [SerializeField]
        private Call call;
        [SerializeField]
        private RoomInvestigate roomInvestigate;        
        [SerializeField]
        private MiddleEnding middleEnding;
        [SerializeField]
        private ReasoningManager reasoningManager;
        [SerializeField]
        private TalkBoxData talkBoxData;
        [SerializeField]
        private checkDiaryDialogue checkDiarydialoge;
        [SerializeField]
        private latelyEvidence lately_Evidence;

        public TalkBoxData TalkBoxData
        {
            get
            {
                if(talkBoxData == null)
                {
                    talkBoxData = GameModel.FindObjectOfType<TalkBoxData>();
                }
                return talkBoxData;
            }
        }
        
        public latelyEvidence latelyEvidence
        {
            get
            {
                if (lately_Evidence == null)
                {
                    lately_Evidence = GameModel.FindObjectOfType<latelyEvidence>();
                }
                return lately_Evidence;
            }
        }

        public checkDiaryDialogue checkDiaryDialogue
        {
            get
            {
                if (checkDiarydialoge == null)
                {
                    checkDiarydialoge = GameModel.FindObjectOfType<checkDiaryDialogue>();
                }
                return checkDiarydialoge;
            }
        }

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
        public AudioManager AudioManager
        {
            get
            {
                if (audioManager == null)
                {
                    audioManager = GameObject.FindObjectOfType<AudioManager>();
                }
                return audioManager;
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
        public MapManager MapManager
        {
            get
            {
                if (mapManager == null)
                {
                    mapManager = GameObject.FindObjectOfType<MapManager>();
                }
                return mapManager;
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

        public ReasoningManager ReasoningManager
        {
            get
            {
                if (reasoningManager==null)
                {
                    reasoningManager = GameModel.FindObjectOfType<ReasoningManager>();
                }
                return reasoningManager;
            }
        }


        public Call Call
        {
            get
            {
                if (call == null)
                {
                    call = GameObject.FindObjectOfType<Call>();
                }
                return call;
            }
        }

        public RoomInvestigate RoomInvestigate
        {
            get
            {
                if (roomInvestigate == null)
                {
                    roomInvestigate = GameObject.FindObjectOfType<RoomInvestigate>();
                }
                return roomInvestigate;
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
        public CallBtn CallBtn
        {
            get
            {
                if(callBtn == null)
                {
                    callBtn = FindObjectOfType<CallBtn>();
                }
                return callBtn;
            }
        }

        public CaseDiaryBtn CaseDiaryBtn
        {
            get
            {
                if (caseDiaryBtn == null)
                {
                    caseDiaryBtn = GameObject.FindObjectOfType<CaseDiaryBtn>();
                }
                return caseDiaryBtn;
            }
        }
        public Clock Clock
        {
            get
            {
                if (hp == null)
                {
                    clock = GameObject.FindObjectOfType<Clock>();
                }
                return clock;
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



        public SettingBtn SettingBtn
        {
            get
            {
                if (settingBtn == null)
                {
                    settingBtn = GameObject.FindObjectOfType<SettingBtn>();
                }
                return settingBtn;
            }
        }

        public MiddleEnding MiddleEnding
        {
            get
            {
                if (middleEnding == null)
                {
                    middleEnding = GameObject.FindObjectOfType<MiddleEnding>();
                }
                return middleEnding;
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