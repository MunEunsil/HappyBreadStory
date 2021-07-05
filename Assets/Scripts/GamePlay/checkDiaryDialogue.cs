using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class checkDiaryDialogue : MonoBehaviour
    {
        public void checkDialoge(string name)
        {
            int day = DataManager.Instance.date;
            switch (name)
            {
                case "twist":
                    if (DataManager.Instance.twist == 1)
                    {
                        GameModel.Instance.TalkBoxData.twist_DialogeKeywordsOpen[0] = 1;
                    }
                    break;
                case "hodu":
                    if (DataManager.Instance.hodu == 1)
                    {
                        GameModel.Instance.TalkBoxData.hodu_DialogeKeywordsOpen[0] = 1;
                    }
                    break;
                case "maca":
                    if (DataManager.Instance.maca == 1)
                    {
                        GameModel.Instance.TalkBoxData.maca_DialogeKeywordsOpen[0] = 1;
                    }
                    break;
                case "straw":
                    if (DataManager.Instance.straw == 1)
                    {
                        GameModel.Instance.TalkBoxData.strawDialogeKeywordsOpen[0] = 1;
                    }
                    break;
                case "crois":
                    if (DataManager.Instance.crois == 1)
                    {
                        GameModel.Instance.TalkBoxData.crois_DialogeKeywordsOpen[0] = 1;
                    }
                    break;
            }
        }
    }
}
