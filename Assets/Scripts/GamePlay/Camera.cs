using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HappyBread.GamePlay.GameState;

namespace HappyBread.GamePlay
{
    /// <summary>
    /// 카메라를 제어하는 클래스.
    /// </summary>
    public class Camera : MonoBehaviour
    {
        public GameObject target;
        public float followingTime = 0.3f;
        Vector2 currentVelocity;
        Camera camera;
        Vector3 MousePosition;

        public bool RI = false; //방 조사 

        // Update is called once per frame
        void Update()
        {

            if (RI == true)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    MousePosition = Input.mousePosition;
                   
                   // MousePosition = camera.ScreenToWorldPoint(MousePosition);
                }
            }
            else
            {
                Vector2 newPosition = Vector2.SmoothDamp(transform.position, target.transform.position, ref currentVelocity, followingTime);
                transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);

              

            }


        }

        //raycate를 위한 코드
        private void Start()
        {
            
            camera = GetComponent<Camera>();
           
        }
    }
}
