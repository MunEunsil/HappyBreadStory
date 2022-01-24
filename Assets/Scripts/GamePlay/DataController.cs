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
        private SaveGameData saveData = new SaveGameData();
        //엔딩 파일 읽기 
        public SaveEndingData saveEndingData = new SaveEndingData();   //각 엔딩 스크립트에서 접근할것이기 때문에 public




        private string SAVE_DATA_DIRECTORY; //저장할 폴더 경로
        private string SAVE_FILENAME="/SaveFile.txt";//세이브 파일 이름

        private string SAVE_ENDINGS_DIRECTORY; //엔딩 저장할 폴더 경로
        private string ENDING_FILENAME = "/EndingFile.txt"; //엔딩 저장 파일 이름



        //static GameObject _container;
        //static GameObject Container
        //{
        //    get
        //    {
        //        return _container;
        //    }
        //}

        //static DataController _instance;
        //public static DataController instance
        //{
        //    get
        //    {
        //        if (!_instance)
        //        {
        //            _container = new GameObject();
        //            _container.name = "DataController";
        //            _instance = _container.AddComponent(typeof(DataController)) as DataController;
        //            DontDestroyOnLoad(_container);
        //        }
        //        return _instance;
        //    }
        //}



      //  public string GameDataFileName = "savePoint.json"; //이름변경금지



        //public GameData _gmaeData;
        //public GameData gameData
        //{
        //    get
        //    {
        //        if (_gmaeData == null)
        //        {
        //            LoadGameData();
        //            saveGameData();
        //        }
        //        return _gmaeData;
        //    }
        //}

        //public void LoadGameData()
        //{
        //    string filePath = Application.persistentDataPath + GameDataFileName;

        //    if (File.Exists(filePath))
        //    {
        //        Debug.Log("불러오기 성공");
        //        string FromJsonData = File.ReadAllText(filePath);
        //        _gmaeData = JsonUtility.FromJson<GameData>(FromJsonData);

        //    }
        //    else
        //    {
        //        Debug.Log("새로운 파일 생성");

        //        _gmaeData = new GameData();
        //    }
        //}

        private void Start()
        {
            // LoadGameData();
            SAVE_DATA_DIRECTORY = Application.dataPath + "/Save/";

            SAVE_ENDINGS_DIRECTORY = Application.dataPath + "/Save";
            

            if (!Directory.Exists(SAVE_DATA_DIRECTORY))//해당 경로가 존재하지 않는다면
            {
                Directory.CreateDirectory(SAVE_DATA_DIRECTORY); //폴더생성(경로 생성)

            }

            //엔딩 데이터 파일없으면 생성
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
            saveData.date = DataManager.Instance.date;

            //증거가 있으면 
            //증거 이름만 저장
            if (DataManager.Instance.evidences != null)
            {
                for (int j = 0; j < DataManager.Instance.evidences.Count; j++)
                {
                    saveData.evidence_name.Add(DataManager.Instance.evidences[j].Name); //모든 증거품 Name 추가 및 확인
                }
                //증거 sprite만 저장 
                for (int j = 0; j < DataManager.Instance.evidences.Count; j++)
                {
                    saveData.evidence_Sprite.Add(DataManager.Instance.evidences[j].Sprite); //모든 증거품 Sprite 추가 및 확인
                }
            }




            string json = JsonUtility.ToJson(saveData); //제이슨화

            File.WriteAllText(SAVE_DATA_DIRECTORY + SAVE_FILENAME, json);

            Debug.Log("저장해뜸!");
            Debug.Log(json);
            

        }

        //로드하기
        public void LoadData()
        {
            //
            if (File.Exists(SAVE_DATA_DIRECTORY + SAVE_FILENAME))
            {
                //전체 읽어오기
                string loadjson = File.ReadAllText(SAVE_DATA_DIRECTORY + SAVE_FILENAME);
                saveData = JsonUtility.FromJson<SaveGameData>(loadjson);

                //date 로드 
                DataManager.Instance.date = saveData.date;

                //증거 이름
                for (int j = 0; j < saveData.evidence_name.Count; j++)
                { 
                    //DataManager.Instance.evidences.Add(saveData.evidences[j]);
                    //DataManager.Instance.evidences[j].Name = saveData.evidence_Sprite[j];
                    DataManager.Instance.evidences.Insert(j,new Evidence() { Name = saveData.evidence_name[j], Sprite = saveData.evidence_Sprite[j] });

                    
                } 
         

                //딸기대화 키워드 오픈 로드 
                for (int i = 0; i < saveData.straw_keyword.Count; i++)
                {
                    DataManager.Instance.straw_DialogeKeywordsOpen[i] = saveData.straw_keyword[i];
                   // Debug.Log("딸기대화 키워드 오픈여부 로드"+i);

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
            //중간엔딩
            for (int j = 0; j < 11; j++)
            {
                saveEndingData.Ending.Add(DataManager.Instance.ending_[j]);
            }

            //해피/안해피 엔딩
            saveEndingData.HappyEnding.Add(DataManager.Instance.ending_happyEnding[0]);
            saveEndingData.HappyEnding.Add(DataManager.Instance.ending_happyEnding[1]);

            string json = JsonUtility.ToJson(saveEndingData); //제이슨화

            File.WriteAllText(SAVE_ENDINGS_DIRECTORY + ENDING_FILENAME, json);

            Debug.Log("엔딩 저장했음!");
            Debug.Log("엔딩 저장 json 확인 =>>> " + json);

        }


        ////엔딩을 로드하는 함수
        public void Load_Ending()
        {
            // Application.dataPath + "/Save/"+"/SaveFile.txt"
            if (File.Exists(SAVE_DATA_DIRECTORY + SAVE_FILENAME))
            {
                //전체 읽어오기
                string load_Ending_json = File.ReadAllText(SAVE_ENDINGS_DIRECTORY + ENDING_FILENAME);
                saveEndingData = JsonUtility.FromJson<SaveEndingData>(load_Ending_json);

 
                for (int j = 0; j < 11; j++)
                {
                    //DataManager.Instance.ending_ = saveEndingData.Ending;
                    DataManager.Instance.ending_[j] = saveEndingData.Ending[j];

                }

                Debug.Log("엔딩 로드 -완-");

            }
            else
            {
                Debug.Log("save 없음");
            }
        }


    }
}
