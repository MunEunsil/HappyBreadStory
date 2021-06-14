using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HappyBread.GamePlay;
using System;
using HappyBread.ETC;

namespace HappyBread.GamePlay
{
    public class CharacterDialogue : Interactable
    {
        /// <summary>
        /// 캐릭터와 대화 상호작용을 하는 클래스.
        /// </summary>

        public override void Interact()
        {
            //스크립트 이름 : day n _ 캐릭터 이름 _ 대화 순서 
            string characterName = this.name;
            string textFileName;

            switch (characterName)
            {
                case "cake":
                    DataManager.Instance.cake += 1;
                    textFileName = "day" + GameModel.Instance.Date.Current + "_" + characterName + "_" + DataManager.Instance.cake;
                    if (ResourceLoader.LoadText(textFileName) != null)
                    {
                        //... 대화
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                    }
                    else
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("noneDialogue"));
                    }

                    break;
                case "choco":
                    DataManager.Instance.choco += 1;
                    textFileName = "day" + GameModel.Instance.Date.Current + "_" + characterName + "_" + DataManager.Instance.choco;
                    if (ResourceLoader.LoadText(textFileName) != null)
                    {
                        //... 대화
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                    }
                    else
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("noneDialogue"));
                    }
                    break;

                case "crois":
                    DataManager.Instance.crois += 1;
                    textFileName = "day" + GameModel.Instance.Date.Current + "_" + characterName + "_" + DataManager.Instance.crois;
                    if (ResourceLoader.LoadText(textFileName) != null)
                    {
                        //... 대화
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                    }
                    else
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("noneDialogue"));
                    }
                    break;

                case "donut":
                    DataManager.Instance.donut += 1;
                    textFileName = "day" + GameModel.Instance.Date.Current + "_" + characterName + "_" + DataManager.Instance.donut;
                    if (ResourceLoader.LoadText(textFileName) != null)
                    {
                        //... 대화
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                    }
                    else
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("noneDialogue"));
                    }
                    break;

                case "hodu":
                    DataManager.Instance.hodu += 1;
                    textFileName = "day" + GameModel.Instance.Date.Current + "_" + characterName + "_" + DataManager.Instance.hodu;
                    if (ResourceLoader.LoadText(textFileName) != null)
                    {
                        //... 대화
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                    }
                    else
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("noneDialogue"));
                    }
                    break;

                case "jam":
                    DataManager.Instance.jam += 1;
                    textFileName = "day" + GameModel.Instance.Date.Current + "_" + characterName + "_" + DataManager.Instance.jam;
                    if (ResourceLoader.LoadText(textFileName) != null)
                    {
                        //... 대화
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                    }
                    else
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("noneDialogue"));
                    }

                    break;
                case "jelly":
                    DataManager.Instance.jelly += 1;
                    textFileName = "day" + GameModel.Instance.Date.Current + "_" + characterName + "_" + DataManager.Instance.jelly;
                    if (ResourceLoader.LoadText(textFileName) != null)
                    {
                        //... 대화
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                    }
                    else
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("noneDialogue"));
                    }

                    break;
                case "jellyjelly":
                    DataManager.Instance.jellyjelly += 1;
                    textFileName = "day" + GameModel.Instance.Date.Current + "_" + characterName + "_" + DataManager.Instance.jellyjelly;

                    if (ResourceLoader.LoadText(textFileName) != null)
                    {
                        //... 대화
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                    }
                    else
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("noneDialogue"));
                    }
                    break;

                case "maca":
                    DataManager.Instance.maca += 1;
                    textFileName = "day" + GameModel.Instance.Date.Current + "_" + characterName + "_" + DataManager.Instance.maca;

                    if (ResourceLoader.LoadText(textFileName) != null)
                    {
                        //... 대화
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                    }
                    else
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("noneDialogue"));
                    }

                    break;
                case "pancake":
                    DataManager.Instance.pancake += 1;
                    textFileName = "day" + GameModel.Instance.Date.Current + "_" + characterName + "_" + DataManager.Instance.pancake;

                    if (ResourceLoader.LoadText(textFileName) != null)
                    {
                        //... 대화
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                    }
                    else
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("noneDialogue"));
                    }
                    break;

                case "straw":
                    DataManager.Instance.straw += 1;
                    textFileName = "day" + GameModel.Instance.Date.Current + "_" + characterName + "_" + DataManager.Instance.straw;

                    if (ResourceLoader.LoadText(textFileName) != null)
                    {
                        //... 대화
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                    }
                    else
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("noneDialogue"));
                    }
                    break;

                case "twist":
                    DataManager.Instance.twist += 1;
                    textFileName = "day" + GameModel.Instance.Date.Current + "_" + characterName + "_" + DataManager.Instance.twist;

                    if (ResourceLoader.LoadText(textFileName) != null)
                    {
                        //... 대화
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                    }
                    else
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("noneDialogue"));
                    }
                    break;
                default:
                    break;

            }

            GetEvidence();  //GetDialogue() 로 변경 


        }

        protected override void InitEvidence()   //증거X -> 대화 저장 
        {

        }
        

    }
}
