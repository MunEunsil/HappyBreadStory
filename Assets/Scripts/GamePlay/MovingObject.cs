using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyBread.GamePlay
{
    public abstract class MovingObject : MonoBehaviour
    {
        public float speed;
        public float speedArriveTime;

        protected Vector2 objectDirection;
        protected SpriteRenderer spriteRenderer;
        protected Rigidbody2D rigidBody2D;
        protected Vector2 currentVelocity;
        protected Animator animator;

        protected string animatorWalkX = "WalkX"; // 만약 Animator 변수 값이 이것과 다르다면 new 키워드를 통해 변경한다.
        protected string animatorWalkY = "WalkY"; // 만약 Animator 변수 값이 이것과 다르다면 new 키워드를 통해 변경한다.
        protected string animatorIsWalking = "isWalking"; // 만약 Animator 변수 값이 이것과 다르다면 new 키워드를 통해 변경한다.

        protected enum State
        {
            Idle, // 움직이지 않을 때
            Walking // 움직일 때
        }

        /// <summary>
        /// 인자로 받은 방향으로 움직입니다.
        /// </summary>
        /// <param name="direction">대상이 움직여질 방향</param>
        protected virtual void Move(Vector2 direction)
        {
            if (!animator.GetBool(animatorIsWalking))
            {
                animator.SetBool(animatorIsWalking, true);
            }

            objectDirection = direction.normalized;
            spriteRenderer.flipX = objectDirection.x > 0 ? false : objectDirection.x < 0 ? true : spriteRenderer.flipX;
            rigidBody2D.velocity = Vector2.SmoothDamp(rigidBody2D.velocity, objectDirection * speed, ref currentVelocity, speedArriveTime);

            animator.SetFloat(animatorWalkX, objectDirection.x);
            animator.SetFloat(animatorWalkY, objectDirection.y);
            AfterMove();
        }

        public virtual void Stop()
        {
            if (animator.GetBool(animatorIsWalking))
            {
                animator.SetBool(animatorIsWalking, false);
            }

            if (rigidBody2D.velocity.sqrMagnitude > Vector2.kEpsilon)
            {
                //rigidBody2D.velocity = Vector2.SmoothDamp(rigidBody2D.velocity, Vector2.zero, ref currentVelocity, speedArriveTime);
                rigidBody2D.velocity = Vector2.zero;
            }
            else
            {
                rigidBody2D.velocity = Vector2.zero;
            }
        }

        protected virtual void Awake()
        {
            rigidBody2D = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        protected abstract void AfterMove();
    }
}