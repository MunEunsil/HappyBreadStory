using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HappyBread.GamePlay
{
    public class LoadOpening : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            
            SceneManager.LoadScene("Opening", LoadSceneMode.Additive);
            
        }
    }
}
