
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace HappyBread.GamePlay
{
    /// <summary>
    /// 저장, 불러오기를 위한 클래스 
    /// </summary>
    public class SaveLoad : MonoBehaviour
    {
        static GameObject _container;
        static GameObject Container
        {
            get
            {
                return _container;
            }
        }

        static SaveLoad _instance;
        public static SaveLoad instance
        {
            get
            {
                if (!_instance)
                {
                    _container = new GameObject();
                    _container.name = "SaveLoad";
                    _instance = _container.AddComponent(typeof(SaveLoad)) as SaveLoad;
                    DontDestroyOnLoad(_container);
                }
                return _instance;
            }
        }
        public SaveGameData _gameData;
        public SaveGameData gameData
        {
            get
            {
                //게임이 시작되면 자동으로 실행되도록 
                if (_gameData == null)
                {
                    LoadGameData();
                    SaveGameData();
                }
                return _gameData;
            }
        }
        
        
        // 게임 데이터 파일이름 설정 

        public string GameDataFileName = "MunYaho.json";

        //저장된 게임 불러오기 
        public void LoadGameData()
        {// start 버튼을 누른 이후 바로 시작
            string filePath = Application.persistentDataPath + GameDataFileName;

            if (File.Exists(filePath))  //저장된 게임 ㅇ
            {
                Debug.Log("load 성공");
                string FromJsonData = File.ReadAllText(filePath);
                _gameData = JsonUtility.FromJson<SaveGameData>(FromJsonData);
            }
            else
            {
                Debug.Log("새로운 파일 생성");
               // _gameData = new GameManager();
            }

        }
        //게임 저장하기 
        public void SaveGameData()
        {
            string ToJsonData = JsonUtility.ToJson(gameData);
            string filePath = Application.persistentDataPath + GameDataFileName;
            //이미 저장된 파일이 있다면 덮어쓰기 
            File.WriteAllText(filePath,ToJsonData);

        }

        //게임 종료시 자동저장 
        private void OnApplicationQuit()
        {
            SaveGameData();
        }
    }

}
