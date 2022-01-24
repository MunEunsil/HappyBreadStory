using HappyBread.GamePlay;
using HappyBread.GamePlay.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace HappyBread.GamePlay
{
    public class sponsor_Book : Interactable
    {
        // Start is called before the first frame update
        public GameObject book;
        public GameObject exit_room_button;
        public GameObject sponsorship__List;

        public override void Interact()
        {
            GameModel.Instance.EventManager.AddBlockingEvent(new DialogueEvent("book__"));
            exit_room_button.SetActive(false);
            openBook();
        }

        private void openBook()
        {

            book.SetActive(true);
            sponsorship__List.GetComponent<Sponsorship_List>().bookIndex = 0;
            sponsorship__List.GetComponent<Sponsorship_List>().texts[0].SetActive(false);
            sponsorship__List.GetComponent<Sponsorship_List>().texts[1].SetActive(false);
            sponsorship__List.GetComponent<Sponsorship_List>().texts[2].SetActive(false);
            sponsorship__List.GetComponent<Sponsorship_List>().texts[3].SetActive(false);
            sponsorship__List.GetComponent<Sponsorship_List>().texts[4].SetActive(false);
            sponsorship__List.GetComponent<Sponsorship_List>().texts[5].SetActive(false);
            sponsorship__List.GetComponent<Sponsorship_List>().bookInside.SetActive(false);
            sponsorship__List.GetComponent<Sponsorship_List>().bookSign.SetActive(true);

        }



        protected override void InitEvidence()
        {
           
        }

    }
}