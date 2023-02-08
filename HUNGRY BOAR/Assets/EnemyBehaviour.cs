using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    private float moveSpeed = 4f;
    public int damage;
    public PlayerLife playerLife;
    private Rigidbody2D myRigidBody;
 

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerLife.TakeDamage(damage);
        }
    }

    void Update()
    {
        if (isFacingRight())
        {
            //Move right
            myRigidBody.velocity = new Vector2(moveSpeed, 0f);
        } else
        {
            //Move left
            myRigidBody.velocity = new Vector2(-moveSpeed, 0f);
        }
    }

    private bool isFacingRight()
    {
         return transform.localScale.x > Mathf.Epsilon;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Turn the enemy
        transform.localScale = new Vector2(-(Mathf.Sign(myRigidBody.velocity.x)), transform.localScale.y);
    }
}
