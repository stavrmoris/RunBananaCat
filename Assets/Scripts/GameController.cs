using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ForceJump = 2f;
    public bool CanJump;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        
    }


    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space) && CanJump==true)
        {
            rb.velocity = new Vector2(rb.velocity.x, ForceJump);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Ground")
        {
            CanJump = true;
        }
    }
    void OnCollisionExit2D(Collision2D col)
    {
        if(col.gameObject.tag == "Ground")
        {
            CanJump = false;
        }
    }
}
