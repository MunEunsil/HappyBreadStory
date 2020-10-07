using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class TestHelper : MonoBehaviour
    {
        public string mapName;
        public int date = -1;

        // Start is called before the first frame update
        void Start()
        {
            if(date != -1)
            {
                GameModel.Instance.Date.SetDate(date);
            }

            if (!mapName.Equals(""))
            {
                GameModel.Instance.MapManager.ChangeMap(mapName);
            }

            GameModel.Instance.EffectManager.FadeIn();
            GameModel.Instance.StateManager.SetState(new PlayingState());
        }
    }
}
