using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HappyBread.GamePlay
{
    public class forRay : MonoBehaviour
    {
        float MaxDistance = 15f;
        Vector3 MousePosition;
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
                MousePosition = Input.mousePosition;

                MousePosition = cam.ScreenToWorldPoint(MousePosition);

                RaycastHit2D hit = Physics2D.Raycast(MousePosition, transform.forward, MaxDistance);

                Debug.DrawRay(MousePosition, transform.forward*10,Color.red,0.3f);

                if (hit)
                {
                    hit.transform.GetComponent<SpriteRenderer>().color = Color.red;
                }
            }
        }
    }
}