using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HappyBread.GamePlay
{
    public class MapManager : MonoBehaviour
    {
        private string currentMap = null;

        public void ChangeMap(string mapName)
        {
            if (currentMap != null)
            {
                SceneManager.UnloadSceneAsync(currentMap);
            }
            SceneManager.LoadScene(mapName, LoadSceneMode.Additive);
            currentMap = mapName;
        }
    }
}
