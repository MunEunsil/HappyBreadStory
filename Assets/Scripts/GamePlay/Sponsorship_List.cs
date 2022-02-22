using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class Sponsorship_List : MonoBehaviour
    {
        /// <summary>
        /// 후원자 목록을 보여주기위한 클래스
        /// </summary>
        // Start is called before the first frame update

        public GameObject bookSign;
        public GameObject bookInside;
        public GameObject[] texts = new GameObject[6];
        public int bookIndex;

        public GameObject RoomExit_Button;


        public GameObject bookOBJ;

        public GameObject DoorObject;

        private void Start()
        {
            //bookIndex = 0;
            //bookSign.SetActive(true);
            //bookInside.SetActive(false);
        }

        public void click_right__Button()
        {//오른쪽 버튼 눌렀을 떄 
            GameModel.Instance.AudioManager.PlayEffectAudio("paper");
            if (bookIndex == 0)
            {
                bookSign.SetActive(false);
                bookInside.SetActive(true);
                texts[0].SetActive(true);
              //  texts[1].SetActive(false);
                bookIndex++;
            }
            else if (bookIndex == 6)
            {
                Debug.Log(" 마지막 페이지 입니다. ");
            }
            else
            {
                texts[bookIndex-1].SetActive(false);
                texts[bookIndex].SetActive(true);
                bookIndex++;
            }
        }

        public void click_left__button()
        {
            GameModel.Instance.AudioManager.PlayEffectAudio("paper");
            if (bookIndex == 0)
            {
                Debug.Log("첫페이지 입니다."); 

            }
            else if (bookIndex == 1)
            {
                bookSign.SetActive(true);
                bookInside.SetActive(false);
                bookIndex--;
                texts[0].SetActive(false);
            }
            else
            {
                texts[bookIndex - 1].SetActive(false);
                texts[bookIndex - 2].SetActive(true);
                bookIndex--;
            }
        }

        public void exit__room()
        {
            Debug.Log("방 나가기 버튼");
            DoorObject.GetComponent<RoomDoor>().exitButton();
        }

        public void exit__book()
        {
            Debug.Log("책에서 나가기 버튼");
            bookOBJ.SetActive(false);
            RoomExit_Button.SetActive(true);
            GameModel.Instance.UIManager.BasicUIHide();

        }
        //if(gameObject.activeSelf == true


    }
}