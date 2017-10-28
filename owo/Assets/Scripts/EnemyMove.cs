using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    // Use this for initialization
    //variables used for speed, speed will only be set to 0 for a second when the dog barks
    public float walkSpeed;
    private float currentSpeed;
    //Timer used to freeze the bad guy on Bark
    private int stopTimer;
    void Start ()
    {
        currentSpeed = walkSpeed;
        stopTimer = 61;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Move the dude
        transform.Translate(currentSpeed * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(KeyCode.E))
        {
            currentSpeed = 0;
            stopTimer = 0;
        }
        if (stopTimer == 60)
            currentSpeed = walkSpeed;
        stopTimer++;
            
    }
}
