using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    /// <summary>
    /// 상호작용 가능한 물체의 경우 상속받아야할 클래스.
    /// </summary>
    public abstract class Interactable : MonoBehaviour
    {
        // 상호 작용이 가능한 물체는 언제나 증거가 될 수 있다.
        // 때문에 이 곳에는 그에 대한 상세 내용을 작성해야한다.
        public Evidence Evidence { get; protected set; } 

        public Dialogue Dialogue { get; protected set; }

        public abstract void Interact();

        /// <summary>
        /// 해당 객체에 존재하는 Evidence를 획득할지 물어보고 가져옵니다.
        /// </summary>
        protected void GetEvidence()
        {
            if(Evidence == null)
            {
                Debug.Log("Evidennce is null");
                return;
            }

            if (!GameModel.Instance.CaseDiary.Contains(Evidence))
            {
                GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("addEvidence"));
                List<Event> events = new List<Event>();
                events.Add(new ActionEvent(() => { GameModel.Instance.CaseDiary.AddEvidence(Evidence); }));
                events.Add(new ActionEvent(() => { }));
                GameModel.Instance.EventManager.AddBlockingEvent(new AnswerEvent(events));
            }
        }
        //대화 저장 



        /// <summary>
        /// Evidence에 대하여 정의내립니다.
        /// 만약 Evidence가 필요하지 않다면 빈 메서드로 구현합니다.
        /// </summary>
        protected abstract void InitEvidence();
       // protected abstract void InitDialogue(); 

        private void Awake()
        {
            InitEvidence();
        }
    }
}
