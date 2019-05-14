using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{

    public float timeDelay = 1f;
    int damage = 1;
    public int health;
    public int numOfHearts;
    
    private bool canTakeDamage = true;

    public Image[] hearts;
    public Sprite Fullhearts;
    public Sprite emptyhearts;

    public Rigidbody2D deathBody;


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "enemy")
        {


            health -= damage;
           
        }

    }

    void Update()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = Fullhearts;
            }
            else
            {
                hearts[i].sprite = emptyhearts;
                if (i < numOfHearts)
                {

                    hearts[i].enabled = true;
                }
                else
                {
                    hearts[i].enabled = false;
                }
                
                if (health > numOfHearts)
                {
                    health = numOfHearts;
                }
                if (health > 0 )
                {

                }
                
            }
            
        }
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }

        
}

