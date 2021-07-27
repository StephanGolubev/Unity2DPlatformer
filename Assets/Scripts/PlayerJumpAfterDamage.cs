using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpAfterDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D theRB; 
    public float jumpHight;
    public float jumpLeft;
    private bool jumpedOrNot;
    private Animator anim;
    public static PlayerJumpAfterDamage instance;

    private void Awake() {
        instance = this;
    }

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame  
    void Update()
    {
        if (jumpedOrNot)
        {
            theRB.velocity = new Vector2(jumpLeft, theRB.velocity.y);
        }
    }

    public void JumpDamageNow(){
        theRB.velocity = new Vector2(jumpLeft, theRB.velocity.y + jumpHight);
        jumpedOrNot = true;
        anim.SetTrigger("hurt");
    }
}
