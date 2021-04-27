using HappyBread.ETC;
using System.Collections.Generic;

namespace HappyBread.GamePlay
{
    public class CharacterDialogue : Interactable
    {
        public override void Interact()
        {
            string characterName = this.name;
            string textFileName = "day" + DataManager.Instance.date + "_"+ characterName;

            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));

            GetEvidence();  //GetDialogue() 로 변경 
        }

        protected override void InitEvidence()   //증거X -> 대화 저장 
        {
            //Evidence = new Evidence() 
            //{
            //    Name = "Block",
            //    Content = "정체를 알 수 없는 블록이다.",      //?
            //    Sprite = "stone",
            //    Action = () =>
            //    {
            //        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("stone"));  //이게 증거 탭에 들어가는 부분인거같다. 
            //    }
            //};

        }
    }
}
