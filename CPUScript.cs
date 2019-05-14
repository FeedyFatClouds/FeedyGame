using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CPUScript : MonoBehaviour
{

    private BossActionType eCurState = BossActionType.Idle;
    private bool dirRight = true;
    public float speed = 2.0f;


    public enum BossActionType
    {
        Idle,
        Moving,
        AvoidingObstacle,
        Patrolling,
        Attacking
    }

    IEnumerator MoveLeft()
    {
        yield return new WaitForSeconds(1.0f);
        dirRight = false;
        if (dirRight == false)
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
        StartCoroutine(MoveRight());

    }

    IEnumerator MoveRight()
    {
        yield return new WaitForSeconds(1.0f);
        dirRight = true;
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        StartCoroutine(MoveLeft());
    }

    void Update()
    {


        switch (eCurState)
        {
            case BossActionType.Idle:
                if (dirRight)
                    transform.Translate(Vector2.right * speed * Time.deltaTime);
                StartCoroutine(MoveLeft());

                //HandleIdleState();
                break;

            case BossActionType.Moving:
                if (dirRight == false && transform.position.x >= 4.0f)
                    transform.Translate(-Vector2.right * speed * Time.deltaTime);
                Debug.Log("Sweet Sweet");
                //HandleMovingState();
                break;

            case BossActionType.AvoidingObstacle:
                //HandleAvoidingObstacleState();
                break;

            case BossActionType.Patrolling:
                //HandlePatrollingState();
                break;

            case BossActionType.Attacking:
                //HandleAttackingState();
                break;
        }
    }
}