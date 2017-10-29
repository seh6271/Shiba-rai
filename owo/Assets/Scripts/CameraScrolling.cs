using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScrolling : MonoBehaviour {

    public float scollSpeed;
    public GameObject player;
    public float raise;
    public float check;

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
		Vector3 pos = transform.position;
		pos.y = target.position.y + 11;
		transform.position = pos;
    }
}
