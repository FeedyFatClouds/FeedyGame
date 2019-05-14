using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShroomMovement : MonoBehaviour {

    [SerializeField]
    private float speed;
    private float distance;
   public float stoppingDistance;
    private bool facingRight = true;
    private Transform target;
    public Transform groundDetection;





    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, target.position);
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if(groundInfo.collider == false)
        {
            if(facingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                facingRight = false;


            }else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                facingRight = true;

            }
           
        }
        if (distance < stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            
        }

    }
}
