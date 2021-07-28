using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class newsPaper : Interactable
    {
        public override void Interact()
        {
            int date = GameModel.Instance.Date.Current;
            int num = DataManager.Instance.newsnum;
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent($"day{date}_newspaper_{num}"));
            addNum();
            GetEvidence();
        }

        protected override void InitEvidence()
        {
            int date = GameModel.Instance.Date.Current;
            int num = DataManager.Instance.newsnum;

            Evidence = new Evidence()
            {
                Sprite = $"유저신문기사_day{date}_{num}",
                Action = () =>
                {
                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent($"day{date}_newspaper_{num}"));

                }
            };


        }
        void addNum()
        {
            if (DataManager.Instance.newsnum == 1)
            {
                DataManager.Instance.newsnum = 2;
            }
            else
            {
                DataManager.Instance.newsnum = 1;
            }
        }


    }
}
