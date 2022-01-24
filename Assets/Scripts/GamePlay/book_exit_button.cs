using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HappyBread.GamePlay
{
    public class book_exit_button : Interactable
    {
        public GameObject book;
        public GameObject roomExitButton;

        public override void Interact()
        {
            book.SetActive(false);
            roomExitButton.SetActive(true);
        }

        protected override void InitEvidence()
        {
        }
    }

}