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

    private Animator animator;

	// Use this for initialization
	void Start () {
        rBody = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        forwardSpeed = walkSpeed + increment;
        backwardsSpeed = walkSpeed - increment - 5;
        currentSpeed = walkSpeed;
    }
	
	// Update is called once per frame
	void Update () {

        if (rBody.velocity.y == 0)
        {
            animator.SetInteger("Action", 0);
        }

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
            animator.SetInteger("Action", 1);
        }

        //walk check
        if(Input.GetKey(KeyCode.D))
        {
            currentSpeed = forwardSpeed;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            currentSpeed = backwardsSpeed;
        }
        else
        {
            currentSpeed = walkSpeed;
        }
    }

    
}
