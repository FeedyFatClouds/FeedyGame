using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{


    
    public float speed;
    public float stoppingDistance;
    private Transform target;






    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void Update()
    {
        float distance = Vector2.Distance(transform.position, target.position);
        Debug.Log(distance);
        if (distance < stoppingDistance)
        {
            Debug.Log("Enemy follow player");
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}