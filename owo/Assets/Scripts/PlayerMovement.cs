using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//controls players movement
public class PlayerMovement : MonoBehaviour {
  
    private Rigidbody2D rBody;

    public float velocity;
    public float walkSpeed;

	// Use this for initialization
	void Start () {
        rBody = gameObject.GetComponent<Rigidbody2D>();        
    }
	
	// Update is called once per frame
	void Update () {

        ConstantMovement();

        //jump check
        if (Input.GetKeyDown(KeyCode.W))
        {
            rBody.AddRelativeForce(Vector2.up * rBody.mass * (velocity * 200) * Time.deltaTime);            
        }       
    }

    public void ConstantMovement()
    {
        transform.Translate(walkSpeed * Time.deltaTime, 0, 0);
        //rBody.MovePosition((rBody.transform.position + new Vector3(walkSpeed, 0,0)));
    }

    
}
