using HappyBread.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace HappyBread.GamePlay
{
    public class CaseDiary : MonoBehaviour
    {
        public GameObject blankEvidenceObject;
        public GameObject content;
        public KeyCode NextCommand;
        private List<Evidence> evidences = new List<Evidence>();
        private List<GameObject> evidencesObject = new List<GameObject>();

        public void AddEvidence(Evidence evidence)
        {
            evidences.Add(evidence);
            Render();
        }

        public void DeleteEvidence(int index)
        {
            evidences.RemoveAt(index);
            Render();
        }

        private void OnEnable()
        {
            Render();
        }

        private void Render()
        {
            foreach (GameObject obj in evidencesObject)
            {
                Destroy(obj);
            }

            foreach (Evidence evidence in evidences)
            {
                GameObject newEvidenceObject = Instantiate<GameObject>(blankEvidenceObject, content.transform);
                newEvidenceObject.GetComponent<Image>().sprite = evidence.Sprite;
                evidencesObject.Add(newEvidenceObject);
            }
        }

        private void Update()
        {
            if (NextCommand != KeyCode.None)
            {
                if (NextCommand == KeyCode.A)
                {
                    Exit();
                }
            }
        }

        private void Exit()
        {
            GameModel.Instance.inputManager.UndoState();
            NextCommand = KeyCode.None;
            gameObject.SetActive(false);
        }
    }

}