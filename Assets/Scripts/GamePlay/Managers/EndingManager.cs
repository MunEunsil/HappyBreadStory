using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HappyBread.GamePlay
{
    public class EndingManager : MonoBehaviour
    {
        /// <summary>
        /// 엔딩을 관리하는 클래스
        /// </summary>
        /// 

        public GameObject happyEnding;
        public GameObject badEnding;


        // Start is called before the first frame update
        void Start()
        {
            if (DataManager.Instance.happyEnding == true)
            {
                happyEnding.SetActive(true);
            }
            else
            {
                badEnding.SetActive(true);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
