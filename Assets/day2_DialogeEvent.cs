using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HappyBread.ETC;
using UnityEngine.SceneManagement;
namespace HappyBread.GamePlay
{
    public class day2_DialogeEvent : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("씬_대화_test"));
        }
        //대화끝나면 
      //  SceneManager.UnloadScene("");
        
    }
}
