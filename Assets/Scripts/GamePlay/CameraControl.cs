using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HappyBread.GamePlay
{
    public class CameraControl : MonoBehaviour
    {
        public GameObject target;
        public float followingTime = 0.3f;
        Vector2 currentVelocity;

        // Update is called once per frame
        void Update()
        {
            Vector2 newPosition = Vector2.SmoothDamp(transform.position, target.transform.position, ref currentVelocity, followingTime);
            transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
        }
    }
}
