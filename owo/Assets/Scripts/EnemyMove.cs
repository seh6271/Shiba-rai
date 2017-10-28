using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    // Use this for initialization
    //variables used for speed, speed will only be set to 0 for a second when the dog barks
    public float walkSpeed;
    private float currentSpeed;
    void Start ()
    {
        currentSpeed = walkSpeed;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(currentSpeed * Time.deltaTime, 0, 0);
    }
}
