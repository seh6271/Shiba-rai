using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScrolling : MonoBehaviour {

    public float scollSpeed;
    public GameObject player;
    public float raise;

    public Transform target;
    public float offset;

    // Use this for initialization
    void Start () {
        target = player.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

        Follow();
        ConstantMovement();
	}

    public void ConstantMovement()
    {
        transform.Translate(scollSpeed * Time.deltaTime, 0, 0);        
    }

    public void Follow()
    {
            raise = target.position.y - transform.position.y;
        if (raise < .01 || raise > .01)
        {
            transform.Translate(0, offset + (raise * 3 * Time.deltaTime), 0);
        }
    }
}
