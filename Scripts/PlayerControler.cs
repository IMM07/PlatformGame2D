using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float runSpeed = 2;
    public float jumpSpeed = 4;
    public Rigidbody2D rb2D;

    public SpriteRenderer spriteR;

    private void Start()
    {
        rb2D.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
      
    }
    private void FixedUpdate()
    {
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
            spriteR.flipX = false;
        }


        else if (Input.GetKey("left") || Input.GetKey("a"))
        {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
            spriteR.flipX = true;


        }
    }

}
