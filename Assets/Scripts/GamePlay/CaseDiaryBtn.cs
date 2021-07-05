using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HappyBread.GamePlay.GameState;

namespace HappyBread.GamePlay
{
    public class CaseDiaryBtn : MonoBehaviour
    {
        public void Appear()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
        public void AttemptOpenCaseDiary()
        {
            GameModel.Instance.CaseDiary.gameObject.SetActive(true);
            GameModel.Instance.StateManager.ChangeState(new CaseDiaryState());
            
            //NextFunctionCommand = KeyCode.None;
        }
    }
}
