using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public Vector3[] waypoints; //이동포인트 배열
    private Vector3 currPosition; //현재 위치 
    private int waypointIndex = 0; //이동포인트 인덱스
    private float speed = 0.5f;

    protected Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        //이동중인 현위치 변수에 담기
        currPosition = transform.position;

        //이동지점 배열의 인덱스 0부터 배열크기까지
        if (waypointIndex < waypoints.Length)
        {
            animator.SetBool("isWalking", true);
            float step = speed * Time.deltaTime;

            transform.position = Vector3.MoveTowards(currPosition, waypoints[waypointIndex], step);


            //현재위치가 이동지점이라면 배열인덱스+1 하여 다음 포인트로 이동
            if (Vector3.Distance(waypoints[waypointIndex], currPosition) == 0f)
            {

                waypointIndex++;
            }

        }
        else
        {
            animator.SetBool("isWalking", false);
        }

    }
}
