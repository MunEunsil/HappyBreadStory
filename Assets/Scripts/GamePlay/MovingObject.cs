using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public class MovingObject : MonoBehaviour
    {
        public float speed;
        public float speedArriveTime;

        protected Vector2 objectDirection;
        protected SpriteRenderer spriteRenderer;
        protected Rigidbody2D rigidBody2D;
        protected Vector2 currentVelocity;
        protected Animator animator;

        protected virtual void Move(Vector2 direction)
        {
            objectDirection = direction.normalized;
            spriteRenderer.flipX = objectDirection.x > 0 ? false : objectDirection.x < 0 ? true : spriteRenderer.flipX;
            rigidBody2D.velocity = Vector2.SmoothDamp(rigidBody2D.velocity, objectDirection * speed, ref currentVelocity, speedArriveTime);

            animator.SetFloat("WalkX", objectDirection.x);
            animator.SetFloat("WalkY", objectDirection.y);
        }

        protected virtual void Awake()
        {
            rigidBody2D = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
    }
}