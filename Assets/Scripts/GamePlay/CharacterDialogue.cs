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
        /// 캐릭터와 대화 상호작용을 하는 클래스. (원 수정 - 2021.03.23)
        /// 특정 대화는 사건수첩의 키워드를 열기 위해 datamanager의 정보를 수정합니다. (은실 수정 - 2021.24.27)
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
                        if (textFileName == "day1_cake_2")
                        {
                            DataManager.Instance.cake_DialogeKeywordsOpen[0] = true;
                        }
                        else if (textFileName == "day2_cake_1")
                        {
                            DataManager.Instance.cake_DialogeKeywordsOpen[1] = true;
                        }
                        else if (textFileName == "day2_cake_2")
                        {
                            DataManager.Instance.cake_DialogeKeywordsOpen[2] = true;
                        }
                        else if (textFileName == "day4_cake_1")
                        {
                            DataManager.Instance.cake_DialogeKeywordsOpen[4] = true;
                        }
                        else if (textFileName=="day3_cake_1")
                        {
                            DataManager.Instance.cake_DialogeKeywordsOpen[3] = true;
                        }

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

                        if (textFileName == "day1_choco_3")
                        {
                            DataManager.Instance.choco_DialogeKeywordsOpen[0] = true;
                            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                        }
                        else if (textFileName == "day2_choco_1")
                        {
                            choco_day2_1_choice();
                            //DataManager.Instance.choco_DialogeKeywordsOpen[1] = true;
                        }
                        else if (textFileName == "day2_choco_3")
                        {
                            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                            DataManager.Instance.choco_DialogeKeywordsOpen[2] = true;
                        }
                        else if (textFileName == "day3_choco_1")
                        {
                            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                            DataManager.Instance.choco_DialogeKeywordsOpen[3] = true;
                        }
                        else if (textFileName == "day4_choco_1")
                        {
                            choco_day4_1_choice();
                        }
                        else
                        {
                            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                        }
                       

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
                        //... 대화;
                        if (textFileName == "day2_crois_2")
                        {
                            if (DataManager.Instance.day2Crois_lie == true)
                            {
                                GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                            }
                        }
                        else
                        {
                            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                        }
                        
;
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
                        if (textFileName == "day3_donut_1")
                        {
                            DataManager.Instance.donut_DialogeKeywordsOpen[0] = true;
                            donutDay3_choice();
                        }
                        else if (textFileName == "day4_donut_1")
                        {
                            DataManager.Instance.donut_DialogeKeywordsOpen[3] = true;
                            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                        }
                        else
                        {
                            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));

                        }
                     //   GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                        //GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
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
                        if (textFileName == "day1_hodu_1")
                        {
                            DataManager.Instance.hodu_DialogeKeywordsOpen[0] = true;
                        }
                        else if (textFileName == "day2_hodu_1")
                        {
                            DataManager.Instance.hodu_DialogeKeywordsOpen[1] = true;
                        }

                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                       // GameModel.Instance.checkDiaryDialogue.checkKeyword__Test(textFileName);
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
                        if (textFileName == "day1_jam_2")
                        {
                            DataManager.Instance.jam_DialogeKeywordsOpen[0] = true;
                        }
                        else if (textFileName == "day2_jam_1")
                        {
                            DataManager.Instance.jam_DialogeKeywordsOpen[1] = true;
                        }
                        else if (textFileName == "day3_jam_1")
                        {
                            DataManager.Instance.jam_DialogeKeywordsOpen[2] = true;
                        }
                        else if (textFileName == "day4_jam_1")
                        {
                            DataManager.Instance.jam_DialogeKeywordsOpen[3] = true;
                        }

                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                       // GameModel.Instance.checkDiaryDialogue.checkKeyword__Test(textFileName);
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
                        if (textFileName == "day1_jelly_1")
                        {
                            DataManager.Instance.jelly_DialogeKeywordsOpen[0] = true;
                        }
                        else if (textFileName == "day2_jelly_1")
                        {
                            DataManager.Instance.jelly_DialogeKeywordsOpen[1] = true;
                        }
                        else if (textFileName == "day2_jelly_3")
                        {
                            DataManager.Instance.jelly_DialogeKeywordsOpen[2] = true;
                        }
                        else if (textFileName=="day4_jelly_1")
                        {
                            DataManager.Instance.jelly_DialogeKeywordsOpen[3] = true;
                        }


                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                       // GameModel.Instance.checkDiaryDialogue.checkKeyword__Test(textFileName);
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

                        if (textFileName == "day1_jellyjelly_1")
                        {
                            DataManager.Instance.jellyjelly_DialogeKeywordsOpen[0] = true;
                        }
                        else if (textFileName == "day2_jellyjelly_1")
                        {
                            DataManager.Instance.jellyjelly_DialogeKeywordsOpen[1] = true;
                        }
                        else if (textFileName=="day3_jellyjelly_1")
                        {
                            DataManager.Instance.jellyjelly_DialogeKeywordsOpen[2] = true;
                        }

                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                       // GameModel.Instance.checkDiaryDialogue.checkKeyword__Test(textFileName);
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

                        if (textFileName == "day2_maca_1")
                        {
                            DataManager.Instance.maca_DialogeKeywordsOpen[0] = true;
                        }
                        else if (textFileName == "day1_maca_2")
                        {
                            DataManager.Instance.maca_DialogeKeywordsOpen[1] = true;
                        }
                        else if (textFileName == "day3_maca_1")
                        {
                            DataManager.Instance.maca_DialogeKeywordsOpen[2] = true;
                        }
                        else if (textFileName == "day4_maca_1")
                        {
                            DataManager.Instance.maca_DialogeKeywordsOpen[3] = true;
                        }
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                        //GameModel.Instance.checkDiaryDialogue.checkKeyword__Test(textFileName);
                        //GameModel.Instance.checkDiaryDialogue.checkDialoge(characterName);
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
                        if (textFileName == "day1_pancake_1")
                        {
                            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                            DataManager.Instance.pancake_DialogeKeywordsOpen[0] = true;
                        }
                        else if (textFileName == "day2_pancke_1")
                        {
                            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                            DataManager.Instance.pancake_DialogeKeywordsOpen[1] = true;
                        }
                        else if (textFileName == "day3_pancake_1")
                        {
                            // 팬케이크 선택지
                            pancake_choice();
                        }
                        else
                        {
                            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                        }

                       // GameModel.Instance.checkDiaryDialogue.checkKeyword__Test(textFileName);
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
                        if (textFileName == "day1_straw_1")
                        {
                            DataManager.Instance.straw_DialogeKeywordsOpen[0] = true;
                        }
                        else if (textFileName=="day1_straw_2")
                        {
                            DataManager.Instance.straw_DialogeKeywordsOpen[1] = true;
                        }

                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                      //  GameModel.Instance.checkDiaryDialogue.checkKeyword__Test(textFileName);

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
                        //키워드 오픈
                        if (textFileName == "day1_twist_1")
                        {
                            DataManager.Instance.twist_DialogeKeywordsOpen[0] = true;
                            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                        }
                        else if (textFileName == "day1_twist_2")
                        {
                            // DataManager.Instance.twist_DialogeKeywordsOpen[1] = true;
                            twist_day1_choice_1();
                        }
                        else if (textFileName == "day1_twist_3")
                        {
                            //DataManager.Instance.twist_DialogeKeywordsOpen[2] = true;
                            twist_day1_choice_2();
                        }
                        else if (textFileName == "day2_twist_1")
                        {
                            DataManager.Instance.twist_DialogeKeywordsOpen[3] = true;
                            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                            DataManager.Instance.strawRoomKey = true; // 이거 해야 딸기방 들어갈 수있음! 
                        }
                        else if (textFileName == "day4_twist_1")
                        {
                            DataManager.Instance.twist_DialogeKeywordsOpen[5] = true;
                            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                        }
                        else if (textFileName == "day3_twist_1")
                        {
                            //DataManager.Instance.masterKey = true;
                            //DataManager.Instance.twist_DialogeKeywordsOpen[4] = true;
                        }
                        else
                        {
                            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent(textFileName));
                        }
                        
                        
                       // GameModel.Instance.checkDiaryDialogue.checkKeyword__Test(textFileName);
                    }
                    else
                    {
                        GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("noneDialogue"));
                    }
                    break;
                default:
                    break;

            }
            
            


        }
        //2지선다 선택에 따라 달라지는 대화 

        //도넛 day3 
        private void donutDay3_choice()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day3_donut_1"));
            List<Event> events = new List<Event>();
            events.Add(new ActionEvent(() => { DataManager.Instance.donut_DialogeKeywordsOpen[1] = true; GameModel.Instance.CaseDiary.AddEvidence(Evidence); }));
            events.Add(new ActionEvent(() => { DataManager.Instance.donut_DialogeKeywordsOpen[2] = true; }));
            GameModel.Instance.EventManager.AddBlockingEvent(new AnswerEvent(events));

            Evidence = new Evidence()
            {
                Sprite = "evidence_donutHodu",
                Action = () =>
                {
                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("evidence_donutHodu"));

                }

            };
        }
        


        private void pancake_choice()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day3_pancake_1"));
            List<Event> events = new List<Event>();
            events.Add(new ActionEvent(() => { DataManager.Instance.pancake_DialogeKeywordsOpen[2] = true; ; }));
            events.Add(new ActionEvent(() => { }));
            GameModel.Instance.EventManager.AddBlockingEvent(new AnswerEvent(events));
        }

        private void twist_day1_choice_1()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day1_twist_2"));
            List<Event> events = new List<Event>();
            events.Add(new ActionEvent(() => { DataManager.Instance.twist_DialogeKeywordsOpen[1] = true; ; }));
            events.Add(new ActionEvent(() => { DataManager.Instance.twist_DialogeKeywordsOpen[2] = true; }));
            GameModel.Instance.EventManager.AddBlockingEvent(new AnswerEvent(events));

        }
        private void twist_day1_choice_2()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day1_twist_3"));
            List<Event> events = new List<Event>();
            events.Add(new ActionEvent(() => { DataManager.Instance.twist_DialogeKeywordsOpen[1] = true; ; }));
            events.Add(new ActionEvent(() => { DataManager.Instance.twist_DialogeKeywordsOpen[2] = true; }));
            GameModel.Instance.EventManager.AddBlockingEvent(new AnswerEvent(events));

        }

        private void choco_day2_1_choice()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day2_choco_1"));
            List<Event> events = new List<Event>();
            events.Add(new ActionEvent(() => {  ; }));
            events.Add(new ActionEvent(() => { DataManager.Instance.choco_DialogeKeywordsOpen[1] = true; DataManager.Instance.day2Crois_lie = true; }));
            GameModel.Instance.EventManager.AddBlockingEvent(new AnswerEvent(events));
        }
        private void choco_day4_1_choice()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("day4_choco_1"));
            List<Event> events = new List<Event>();
            events.Add(new ActionEvent(() => { DataManager.Instance.twist_DialogeKeywordsOpen[5] = true; GameModel.Instance.CaseDiary.AddEvidence(Evidence); })); // 목격, 증거도 넣어줄것
            events.Add(new ActionEvent(() => { DataManager.Instance.twist_DialogeKeywordsOpen[4] = true; })); // 승진 
            GameModel.Instance.EventManager.AddBlockingEvent(new AnswerEvent(events));

            //초코소라빵의 목격넣어주기
            Evidence = new Evidence()
            {
                Sprite = "evidence_choco_sighting",
                Action = () =>
                {
                    GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("evidence_choco_sighting"));

                }

            };
        }

        protected override void InitEvidence()  
        {
            //Awake

        }
        private void checkKeyword()
        {

        }

    }
}
