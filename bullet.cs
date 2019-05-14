using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rb;

	void Start () {

        rb.velocity = transform.right * speed;




	}
    private void OnTriggerEnter2D (Collider2D hitInfo)
    {
       enemy Enemy = hitInfo.GetComponent<enemy>();
        if (Enemy != null)
        {
            Enemy.TakeDamage(50);
        }

        Destroy(gameObject);
       
    }

}
