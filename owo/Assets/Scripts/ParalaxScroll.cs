using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxScroll : MonoBehaviour {

    public float scollSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ConstantMovement();
	}

    public void ConstantMovement()
    {
        transform.Translate(scollSpeed * Time.deltaTime, 0, 0);
    }
}
