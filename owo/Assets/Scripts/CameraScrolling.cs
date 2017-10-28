using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScrolling : MonoBehaviour {

    public float scollSpeed;
    public GameObject player;
    private float raise;

    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;

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
        if (target)
        {
            raise = target.position.y - transform.position.y;
            transform.Translate(0, raise * 3 * Time.deltaTime, 0);
        }
    }
}
