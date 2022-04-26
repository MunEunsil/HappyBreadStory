using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

namespace HappyBread.GamePlay
{
    public class DataController : MonoBehaviour
    {
        //파일 읽기
        public SaveGameData saveData = new SaveGameData();
        //엔딩 파일 읽기 
        public SaveEndingData saveEndingData = new SaveEndingData();   //각 엔딩 스크립트에서 접근할것이기 때문에 public




        private string SAVE_DATA_DIRECTORY; //저장할 폴더 경로
        private string SAVE_FILENAME="/SaveFile.txt";//세이브 파일 이름

        private string SAVE_ENDINGS_DIRECTORY; //엔딩 저장할 폴더 경로
        private string ENDING_FILENAME = "/EndingFile.txt"; //엔딩 저장 파일 이름




        private void Start()
        {
            // LoadGameData();
            SAVE_DATA_DIRECTORY = Application.dataPath + "/Save/";

            SAVE_ENDINGS_DIRECTORY = Application.dataPath + "/Save";


            if (!Directory.Exists(SAVE_DATA_DIRECTORY))//해당 경로가 존재하지 않는다면
            {
                Directory.CreateDirectory(SAVE_DATA_DIRECTORY); //폴더생성(경로 생성)

            }


            //엔딩 데이터 파일rudfh없으면 생성
            if (!Directory.Exists(SAVE_ENDINGS_DIRECTORY))
            {
                Directory.CreateDirectory(SAVE_ENDINGS_DIRECTORY);
            }

      
            //saveGameData();
        }

        //저장하기
        public void saveGameData()
        {
            
            //date저장 
            saveData.date = DataManager.Instance.date+1;

            //이름저장
            saveData.PlayerNmae = DataManager.Instance.PlayerName;

            saveData.day3FreezerKey = DataManager.Instance.Day3_freezerKey;

            //증거가 있으면 
            //증거 이름만 저장
            if (DataManager.Instance.evidences != null)
            {
                //for (int j = 0; j < DataManager.Instance.evidences.Count; j++)
                //{
                //  //  saveData.evidence_name.Add(DataManager.Instance.evidences[j].Name); //모든 증거품 Name 추가 및 확인
                //    saveData.evidence_name.Insert(j, DataManager.Instance.evidences[j].Name);
                //}
                //증거 sprite만 저장 
                for (int j = 0; j < DataManager.Instance.evidences.Count; j++)
                {
                    saveData.evidence_Sprite.Insert(j, DataManager.Instance.evidences[j].Sprite);
                    //saveData.evidence_Sprite.Add(DataManager.Instance.evidences[j].Sprite); //모든 증거품 Sprite 추가 및 확인
                }
            }
            string json;
            if (File.Exists(SAVE_DATA_DIRECTORY + SAVE_FILENAME))
            {
                File.Delete(SAVE_DATA_DIRECTORY + SAVE_FILENAME); //파일을 지우고 다시 생성

                json = JsonUtility.ToJson(saveData); //제이슨화
                File.WriteAllText(SAVE_DATA_DIRECTORY + SAVE_FILENAME, json);
            }
            else//세이브 파일이 없으면
            {
                json = JsonUtility.ToJson(saveData); //제이슨화

                File.WriteAllText(SAVE_DATA_DIRECTORY + SAVE_FILENAME, json);
            }
            //string json = JsonUtility.ToJson(saveData); //제이슨화

            //File.WriteAllText(SAVE_DATA_DIRECTORY + SAVE_FILENAME, json);

            Debug.Log("저장해뜸!");
            Debug.Log(json);
            

        }

        //로드하기
        public void LoadData()
        {
            Debug.Log("로드 데이터");
            //
            if (File.Exists(SAVE_DATA_DIRECTORY + SAVE_FILENAME))
            {
                //전체 읽어오기
                string loadjson = File.ReadAllText(SAVE_DATA_DIRECTORY + SAVE_FILENAME);
                saveData = JsonUtility.FromJson<SaveGameData>(loadjson);

                //date 로드 
                DataManager.Instance.date = saveData.date;
                //이름 로드 
                DataManager.Instance.PlayerName = saveData.PlayerNmae;
                //냉동창고 열림 여부 
                DataManager.Instance.Day3_freezerKey = saveData.day3FreezerKey;

                //증거 이름, 스프라이트 이름 
                for (int j = 0; j < saveData.evidence_Sprite.Count; j++)
                { 

                    //DataManager.Instance.evidences.Add(saveData.evidences[j]);
                    //DataManager.Instance.evidences[j].Name = saveData.evidence_Sprite[j];
                    //DataManager.Instance.evidences.Insert(j,new Evidence() { Name = saveData.evidence_name[j], Sprite = saveData.evidence_Sprite[j] });
                    DataManager.Instance.evidences.Insert(j, new Evidence() {  Sprite = saveData.evidence_Sprite[j] });

                } 
         
                //딸기대화 키워드 오픈 로드 
                for (int i = 0; i < saveData.straw_keyword.Count; i++)
                {
                    DataManager.Instance.straw_DialogeKeywordsOpen[i] = saveData.straw_keyword[i];
                }

                //팬케이크 대화 키워드 오픈 
                for (int i = 0; i < saveData.pancake_keyword.Count; i++)
                {
                    DataManager.Instance.pancake_DialogeKeywordsOpen[i] = saveData.pancake_keyword[i];
                }

                //컵케이크 대화 키워드 오픈 
                for (int i = 0; i < saveData.cake_keyword.Count; i++)
                {
                    DataManager.Instance.cake_DialogeKeywordsOpen[i] = saveData.cake_keyword[i];
                }
                //크로아상 대화 키웓 ㅡ오픈
                for (int i = 0; i < saveData.crois_keyword.Count; i++)
                {
                    DataManager.Instance.crois_DialogeKeywordsOpen[i] = saveData.crois_keyword[i];
                }
                //마카롱 대화 키워드 오픈
                for (int i = 0; i < saveData.maca_keyword.Count; i++)
                {
                    DataManager.Instance.maca_DialogeKeywordsOpen[i] = saveData.maca_keyword[i];
                }

                //젤리 대화 키워드 오픈
                for (int i = 0; i < saveData.jelly_keyword.Count; i++)
                {
                    DataManager.Instance.jelly_DialogeKeywordsOpen[i] = saveData.jelly_keyword[i];
                }

                //젤리젤리 대화 키워드 오픈
                for (int i = 0; i < saveData.jellyjelly_keyword.Count; i++)
                {
                    DataManager.Instance.jellyjelly_DialogeKeywordsOpen[i] = saveData.jellyjelly_keyword[i];
                }
                //땅콩잼 대화 키워드 오픈
                for (int i = 0; i < saveData.jam_keyword.Count; i++)
                {
                    DataManager.Instance.jam_DialogeKeywordsOpen[i] = saveData.jam_keyword[i];
                }

                //호두 대화 키워드 오픈
                for (int i = 0; i < saveData.hodu_keyword.Count; i++)
                {
                    DataManager.Instance.hodu_DialogeKeywordsOpen[i] = saveData.hodu_keyword[i];
                }

                //꽈배기 대화 키워드 오픈
                for (int i = 0; i < saveData.twist_keyword.Count; i++)
                {
                    DataManager.Instance.twist_DialogeKeywordsOpen[i] = saveData.twist_keyword[i];
                }

                //소라빵 대화 키워드 오픈
                for (int i = 0; i < saveData.choco_keyword.Count; i++)
                {
                    DataManager.Instance.choco_DialogeKeywordsOpen[i] = saveData.choco_keyword[i];
                }

                //도넛 대화 키워드 오픈
                for (int i = 0; i < saveData.donut_keyword.Count; i++)
                {
                    DataManager.Instance.donut_DialogeKeywordsOpen[i] = saveData.donut_keyword[i];
                }


                Debug.Log("로드 -완-");

                Debug.Log(DataManager.Instance.evidences.Count);
                


            }
            else
            {
                Debug.Log("save 없음");
            }
        }

        public void FortestLoad()
        {
            for (int i = 0; i < DataManager.Instance.evidences.Count; i++)
            {
                DataManager.Instance.evidences.RemoveAt(i);
                Debug.Log("증거 리스트 지우기");
            }
        }

        //private void OnApplicationQuit()
        //{//꺼지면 자동저장
        //    saveGameData();
        //}


        public void Check__Evidence()
        {
            //증거가 어떻게 저장되는지 확인

            Debug.Log(DataManager.Instance.evidences.Count);
            for (int j = 0; j < DataManager.Instance.evidences.Count; j++)
            {
                Debug.Log(DataManager.Instance.evidences[j]);

                Debug.Log("\n 증거 이름 ");
                Debug.Log(DataManager.Instance.evidences[j].Name);
                Debug.Log("\n 증거 이미지 이름 ");
                Debug.Log(DataManager.Instance.evidences[j].Sprite);

            }
            
        }

        //엔딩 저장하는 함수 
        public void Save_Ending()
        {
            saveEndingData.Ending.Clear();
            saveEndingData.HappyEnding.Clear();
            //중간엔딩
            for (int j = 0; j < 11; j++)
            {
                //saveEndingData.Ending.Add(DataManager.Instance.ending_[j]);
                saveEndingData.Ending.Insert(j,DataManager.Instance.ending_[j]);
            }

            //해피/안해피 엔딩
            saveEndingData.HappyEnding.Insert(0, DataManager.Instance.ending_happyEnding[0]);
            saveEndingData.HappyEnding.Insert(1, DataManager.Instance.ending_happyEnding[1]);
            //saveEndingData.HappyEnding.Add(DataManager.Instance.ending_happyEnding[0]);
            //saveEndingData.HappyEnding.Add(DataManager.Instance.ending_happyEnding[1]);

            string json = JsonUtility.ToJson(saveEndingData); //제이슨화

            if (File.Exists(SAVE_DATA_DIRECTORY + ENDING_FILENAME))
            {
                File.Delete(SAVE_DATA_DIRECTORY + ENDING_FILENAME); //파일을 지우고 다시 생성
              
                File.WriteAllText(SAVE_DATA_DIRECTORY + ENDING_FILENAME, json);
            }
            else//세이브 파일이 없으면
            {
                json = JsonUtility.ToJson(saveEndingData); //제이슨화

                File.WriteAllText(SAVE_DATA_DIRECTORY + ENDING_FILENAME, json);
            }
            //File.WriteAllText(SAVE_ENDINGS_DIRECTORY + ENDING_FILENAME, json);

            Debug.Log("엔딩 저장했음!");
            Debug.Log("엔딩 저장 json 확인 =>>> " + json);

        }


        ////엔딩을 로드하는 함수
        public void Load_Ending()
        {
            // Application.dataPath + "/Save/"+"/SaveFile.txt"
            if (File.Exists(SAVE_DATA_DIRECTORY + ENDING_FILENAME))
            {
                //전체 읽어오기
                string load_Ending_json = File.ReadAllText(SAVE_ENDINGS_DIRECTORY + ENDING_FILENAME);
                saveEndingData = JsonUtility.FromJson<SaveEndingData>(load_Ending_json);

 
                for (int j = 0; j < 11; j++)
                {
                    //DataManager.Instance.ending_ = saveEndingData.Ending;
                    DataManager.Instance.ending_[j] = saveEndingData.Ending[j];

                }

                DataManager.Instance.ending_happyEnding[0] = saveEndingData.HappyEnding[0];
                DataManager.Instance.ending_happyEnding[1] = saveEndingData.HappyEnding[1];

                Debug.Log("엔딩 로드 -완-");

            }
            else
            {
                Debug.Log("save 없음");
            }
        }


    }
}
