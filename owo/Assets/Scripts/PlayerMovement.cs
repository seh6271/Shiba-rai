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

	// Use this for initialization
	void Start () {
        rBody = gameObject.GetComponent<Rigidbody2D>();
        forwardSpeed = walkSpeed + increment;
        backwardsSpeed = walkSpeed - increment - 5;
        currentSpeed = walkSpeed;
    }
	
	// Update is called once per frame
	void Update () {

        ConstantMovement();

        CheckInput();


    }

    public void ConstantMovement()
    {
        transform.Translate(currentSpeed * Time.deltaTime, 0, 0);
        //rBody.MovePosition((rBody.transform.position + new Vector3(walkSpeed, 0,0)));
    }

    public void CheckInput()
    {
        //jump check
        if (Input.GetKeyDown(KeyCode.W))
        {
            rBody.AddRelativeForce(Vector2.up * rBody.mass * (velocity * 200) * Time.deltaTime);
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
