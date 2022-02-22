using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HappyBread.GamePlay.GameState;
using UnityEngine.UI;
using HappyBread.ETC;

namespace HappyBread.GamePlay
{
    public class latelyEvidence : MonoBehaviour
    {
        /// <summary>
        /// 최근습득증거UI 를 관리하는 클래스. 
        /// </summary>
        public Image item_1;
        public Image item_2;
        public Image item_3;
        //레이아웃 그룹 - 최적화 문제로 여기선 안씀  


        public void Appear()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        //증거 채우기 
        public void AddEvideceBox()
        {
            for (int i=0; i<3; i++)
            {
                
            }
        }

        
        public void latelyEvidenceTest()   //테스트코드
        {
            //증거 리스트에서 마지막 인덱스 3개 가져와서 이미지 그려주기

            //DataManager.Instance.evidences.Count - 1 : 마지막 인덱스 

            //CaseDiary AddEvidence() 함수에 들어있음

            if (DataManager.Instance.evidences != null) 
            {
                
                int num;


                num = DataManager.Instance.evidences.Count ;
                //3개 그려넣기 
                if (DataManager.Instance.evidences.Count == 1) //증거가 한개 있을 때
                {
                    item_1.GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[num-1].Sprite);
                }
                else if (DataManager.Instance.evidences.Count == 2) //증거가 2개 있을 때
                {
                    item_1.GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[num-2].Sprite);
                    item_2.GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[num-1].Sprite);
                }
                else if (DataManager.Instance.evidences.Count >= 3) //증거가 3개 이상 있을 때
                {

                    item_1.GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[num-3].Sprite);
                    item_2.GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[num-2].Sprite);
                    item_3.GetComponent<Image>().sprite = ResourceLoader.LoadSprite(DataManager.Instance.evidences[num-1].Sprite);
                }

            }

        }

        //기존 증거 지우기 
        public void removeEvidence()
        {
            item_1.GetComponent<Image>().sprite = ResourceLoader.LoadSprite("itembox");
            item_2.GetComponent<Image>().sprite = ResourceLoader.LoadSprite("itembox");
            item_3.GetComponent<Image>().sprite = ResourceLoader.LoadSprite("itembox");
        }


        // evidence Test 
        private void Update()
        {
            //if (Input.GetKeyDown(KeyCode.Space)) 
            //{
            //    int numnum = DataManager.Instance.evidences.Count;
            //    Debug.Log(DataManager.Instance.evidences.Count);
            //    Debug.Log(DataManager.Instance.evidences[numnum-1]);
            //    Debug.Log(DataManager.Instance.evidences[numnum-1].Sprite);

            //}   
        }


        // foreach (Evidence evidence in DataManager.Instance.evidences)
        //{
        //    GameObject newEvidenceObject = Instantiate<GameObject>(blankEvidenceObject, content.transform);
        //    newEvidenceObject.GetComponent<Image>().sprite = ResourceLoader.LoadSprite(evidence.Sprite);
        //    evidencesObject.Add(newEvidenceObject);
        //}        

        //public List<Evidence> evidences = new List<Evidence>();



    }
}