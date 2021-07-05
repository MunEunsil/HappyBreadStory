using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

namespace HappyBread.GamePlay
{
    public class DataController : MonoBehaviour
    {

        static GameObject _container;
        static GameObject Container
        {
            get
            {
                return _container;
            }
        }

        static DataController _instance;
        public static DataController instance
        {
            get
            {
                if (!_instance)
                {
                    _container = new GameObject();
                    _container.name = "DataController";
                    _instance = _container.AddComponent(typeof(DataController)) as DataController;
                    DontDestroyOnLoad(_container);
                }
                return _instance;
            }
        }


        public string GameDataFileName = "savePoint.json"; //이름변경금지

        public GameData _gmaeData;
        public GameData gameData
        {
            get
            {
                if (_gmaeData == null)
                {
                    LoadGameData();
                    SaveGameData();
                }
                return _gmaeData;
            }
        }

        public void LoadGameData()
        {
            string filePath = Application.persistentDataPath + GameDataFileName;

            if (File.Exists(filePath))
            {
                Debug.Log("불러오기 성공");
                string FromJsonData = File.ReadAllText(filePath);
                _gmaeData = JsonUtility.FromJson<GameData>(FromJsonData);

            }
            else
            {
                Debug.Log("새로운 파일 생성");

                _gmaeData = new GameData();
            }
        }

        public void SaveGameData()
        {
            string ToJsonData = JsonUtility.ToJson(gameData);
            string filePath = Application.persistentDataPath + GameDataFileName;
            File.WriteAllText(filePath,ToJsonData);
            Debug.Log("저장 완료");
        }

        private void OnApplicationQuit()
        {//꺼지면 자동저장
            SaveGameData();
        }


    }
}
