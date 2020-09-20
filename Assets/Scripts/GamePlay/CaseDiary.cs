using HappyBread.Core;
using HappyBread.ETC;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace HappyBread.GamePlay
{
    /// <summary>
    /// 증거를 저장하고 관리하는 클래스.
    /// </summary>
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
        }

        public void DeleteEvidence(int index)
        {
            evidences.RemoveAt(index);
        }

        public bool Contains(Evidence evidence)
        {
            return evidences.Contains(evidence);
        }

        private void OnEnable()
        {
            Render();
        }

        private void Render()
        {
            // 기존 object를 삭제한다.
            foreach (GameObject obj in evidencesObject)
            {
                Destroy(obj);
            }

            // 저장된 배열을 토대로 새로 그린다.
            foreach (Evidence evidence in evidences)
            {
                GameObject newEvidenceObject = Instantiate<GameObject>(blankEvidenceObject, content.transform);
                newEvidenceObject.GetComponent<Image>().sprite = ResourceLoader.LoadSprite(evidence.Sprite);
                evidencesObject.Add(newEvidenceObject);
            }
        }

        private void Update()
        {
            // 방향키를 누르는 경우

            // A를 눌렀을 경우
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
            GameModel.Instance.StateManager.UndoState();
            NextCommand = KeyCode.None;
            gameObject.SetActive(false);
        }
    }

}