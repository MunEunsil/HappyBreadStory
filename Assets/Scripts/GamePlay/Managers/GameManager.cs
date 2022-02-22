using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HappyBread.GamePlay.GameState;


namespace HappyBread.GamePlay
{
    /// <summary>
    /// 게임을 관리하는 최상위 클래스.
    /// </summary>
    public class GameManager : MonoBehaviour
    {

        //  public GameObject player;
        public Texture2D cursorImg;
        public Vector2 hotspot;
        // Start is called before the first frame update
        void Start()
        {
             Cursor.SetCursor(cursorImg, Vector2.zero, CursorMode.ForceSoftware);
         //  Cursor.SetCursor(cursorImg, Vector2.zero, CursorMode.Auto);
        }

        // Update is called once per frame
        void Update()
        {

        }

        //public void GameSave()
        //{
        //    //player.x , player.y
        //    PlayerPrefs.SetFloat("player X",player.transform.position.x);
        //    PlayerPrefs.SetFloat("player Y", player.transform.position.y);

        //    //evidence list 


        //    //dialogeKeyword 오픈현황 
        //    //date 
        //    PlayerPrefs.SetInt("date",DataManager.Instance.date);
        //}
        //public void GameLoad() { }
    }
}