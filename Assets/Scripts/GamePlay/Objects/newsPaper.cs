using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class newsPaper : Interactable
    {
        public GameObject news1;
        public GameObject news2;
        public int num;

        public override void Interact()
        {
            int date = GameModel.Instance.Date.Current;
           // int num = DataManager.Instance.newsnum;
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent($"day{date}_newspaper_{num}"));
            // addNum();
            news1.SetActive(false);
            news2.SetActive(true);

            GetEvidence();
        }

        protected override void InitEvidence()
        {
            int date = GameModel.Instance.Date.Current;
         //   int num = DataManager.Instance.newsnum;

            Debug.Log("신문증거 수집 신문넘버 : "+num);
            Evidence = new Evidence()
            {
                Name = $"유저신문기사_day{date}_{num}",
                Sprite = $"day{date}_newspaper_{num}",
                Action = () =>
                {
                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent($"day{date}_newspaper_{num}"));
                    
                }
            };


        }
        
        //void addNum()
        //{
            
        //    if (DataManager.Instance.newsnum == 1)
        //    {
        //        DataManager.Instance.newsnum = 2;
        //        Debug.Log("addNum  신문num" + DataManager.Instance.newsnum);
        //    }
        //    else
        //    {
        //        DataManager.Instance.newsnum = 1;
        //        Debug.Log("addNum  신문num" + DataManager.Instance.newsnum);
        //    }
        //}


    }
}
