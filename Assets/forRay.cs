using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HappyBread.GamePlay
{
    public class forRay : MonoBehaviour
    {
        float mouseDistance15f;
        Vector3 MousePoint;
        Camera cam; 

        // Start is called before the first frame update
        void Start()
        {
            cam = GameObject.Find("Camera").GetComponent<Camera>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                MousePoint = Input.mousePosition;
              //  MousePoint = Camera.main
                
            }
        }
    }
}