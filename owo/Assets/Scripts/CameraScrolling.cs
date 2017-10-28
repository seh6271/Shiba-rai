using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScrolling : MonoBehaviour {

    public float walkSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        ConstantMovement();
	}

    public void ConstantMovement()
    {
        transform.Translate(walkSpeed * Time.deltaTime, 0, 0);
        //rBody.MovePosition((rBody.transform.position + new Vector3(walkSpeed, 0,0)));
    }
}
