using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class checkDiaryDialogue : MonoBehaviour
    {
        //public void checkDialoge(string name)
        //{
        //    int day = DataManager.Instance.date;
        //    switch (name)
        //    {
        //        case "twist":
        //            if (DataManager.Instance.twist == 1)
        //            {
        //                DataManager.Instance.twist_DialogeKeywordsOpen[day-1] = true;
        //                //GameModel.Instance.TalkBoxData.twist_DialogeKeywordsOpen[0] = 1;
        //            }
        //            break;
        //        case "hodu":
        //            if (DataManager.Instance.hodu == 1)
        //            {
        //                DataManager.Instance.hodu_DialogeKeywordsOpen[day - 1] = true;
        //            }
        //            break;
        //        case "maca":
        //            if (DataManager.Instance.maca == 1)
        //            {
        //                DataManager.Instance.maca_DialogeKeywordsOpen[day - 1] = true;
        //            }
        //            break;
        //        case "straw":
        //            if (DataManager.Instance.straw == 1)
        //            {
        //                DataManager.Instance.straw_DialogeKeywordsOpen[day - 1] = true;
        //            }
        //            break;
        //        case "crois":
        //            if (DataManager.Instance.crois == 1)
        //            {
        //                DataManager.Instance.crois_DialogeKeywordsOpen[day - 1] = true;
        //            }
        //            break;
        //    }
        //}

        public void checkKeyword__Test(string textFileName)
        {
            //textFile이름으로 확인 
            //CharacterDialogue 스크립트 참고 
            if (textFileName != null)
            {
                if (textFileName =="day1_straw_1") { DataManager.Instance.straw_DialogeKeywordsOpen[0] = true; }
                if (textFileName == "day1_jam_1") { DataManager.Instance.jam_DialogeKeywordsOpen[0] = true; }
                if (textFileName == "day1_jelly_1") { DataManager.Instance.jelly_DialogeKeywordsOpen[0] = true; }
            }

        }


    }
}
