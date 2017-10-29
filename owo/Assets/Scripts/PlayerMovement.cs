using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//controls players movement
public class PlayerMovement : MonoBehaviour {
  
    private Rigidbody2D rBody;

    public float velocity;
    public float walkSpeed;
    private float currentSpeed;
    private float forwardSpeed;
    private float backwardsSpeed;
    public float increment;
    private float crouchSpeed;
    private float crouchForwardSpeed;
    private float crouchBackwardSpeed;

    public static int animNum;
    private bool police;

    private Animator animator;

	// Use this for initialization
	void Start () {
        rBody = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        forwardSpeed = walkSpeed + increment;
        backwardsSpeed = walkSpeed - increment - 5;
        crouchSpeed = walkSpeed / 1.5f;
        crouchForwardSpeed = crouchSpeed + (increment / 3f);
        crouchBackwardSpeed = crouchSpeed - (increment / 3f) - 5;
        currentSpeed = walkSpeed;
        animNum = 0;
        police = true;
    }
	
	// Update is called once per frame
	void Update () {

        if (rBody.velocity.y == 0)
        {
            animNum = 0;
            animator.SetInteger("Action", animNum);
        }


        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            police = !police;
        }

        if(!police && animNum < 3)
        {
            animNum += 3;            
        }
        else if(police && animNum > 2)
        {
            animNum -= 3;
        }

        animator.SetInteger("Action", animNum);

        ConstantMovement();

        CheckInput();


    }

    public void ConstantMovement()
    {
        transform.Translate(currentSpeed * Time.deltaTime, 0, 0);
    }

    public void CheckInput()
    {

        //jump check
        if (Input.GetKeyDown(KeyCode.W) && (rBody.velocity.y < .5 && rBody.velocity.y > -.3))
        {
            rBody.AddRelativeForce(Vector2.up * rBody.mass * (velocity * 200) * Time.deltaTime);
            animNum = 1;
            animator.SetInteger("Action", animNum);
        }
        //walk check
        if (Input.GetKey(KeyCode.S))
        { 
            animNum = 2;
            animator.SetInteger("Action", animNum);
            currentSpeed = crouchSpeed;            
            return;
        }      
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            currentSpeed = crouchForwardSpeed;
            animNum = 2;
            animator.SetInteger("Action", animNum);
            return;
        }
        if (Input.GetKey(KeyCode.D))
        {
            currentSpeed = forwardSpeed;
            animNum = 0;
            animator.SetInteger("Action", animNum);
            return;
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            currentSpeed = crouchBackwardSpeed;
            animNum = 2;
            animator.SetInteger("Action", animNum);
            return;
        }
        if (Input.GetKey(KeyCode.A))
        {
            currentSpeed = backwardsSpeed;
            animNum = 0;
            animator.SetInteger("Action", animNum);
            return;
        }        

        currentSpeed = walkSpeed;
        
    }

    
}
