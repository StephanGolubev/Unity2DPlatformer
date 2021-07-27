using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D theRB;
    public float jumpForce;
    // Start is called before the first frame update

    private bool isGrounded;
    private bool allowedDualJump;
    public Transform groundCheckPoint;
    public LayerMask whatIsGround;

    private SpriteRenderer theSR;

    private Animator anim;
    public static PlayerController instance;

    private void Awake() {
        instance = this;
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(moveSpeed* Input.GetAxis("Horizontal"), theRB.velocity.y);   

        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, .2f, whatIsGround);

        if (isGrounded)
        {
            allowedDualJump = true;
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded)
            {
                theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
            }else
            {
                if (allowedDualJump)
                {
                    theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
                    allowedDualJump = false;
                }
            }
        }

        if (theRB.velocity.x < 0){
            theSR.flipX = true;
        }else if(theRB.velocity.x > 0){
            theSR.flipX = false;
        }


        anim.SetFloat("moveSpeed", Mathf.Abs(theRB.velocity.x));
        anim.SetBool("isGrounded", isGrounded);
    }
}
