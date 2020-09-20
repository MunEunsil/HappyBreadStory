using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class StartHelper : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameModel.Instance.EffectManager.FadeIn();
            GameModel.Instance.StateManager.SetState(new PlayingState());
        }
    }
}
