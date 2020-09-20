using HappyBread.ETC;
using System.Collections.Generic;

namespace HappyBread.GamePlay
{
    public class Block : Interactable
    {
        public override void Interact()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("test"));
            GetEvidence();
        }

        protected override void InitEvidence()
        {
            Evidence = new Evidence()
            {
                Name = "Block",
                Content = "정체를 알 수 없는 블록이다.",
                Sprite = "stone",
                Action = () =>
                 {

                 }
            };
        }
    }
}
