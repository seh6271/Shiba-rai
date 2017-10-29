using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimManager : MonoBehaviour {

    private Animator animator;
    public GameObject target;

    public bool dogSwitch;
    public int animNum;
    public int switchNum;

	// Use this for initialization
	void Start () {
        animator = target.GetComponent<Animator>();
        dogSwitch = false;
        animNum = 0;
        switchNum = 0;
	}
	
	// Update is called once per frame
	void Update () {
        CheckInput();
        animator.SetInteger("Action", animNum);
	}

    void CheckInput()
    {
        SwitchDog();

        //dog is crouching
        if(Input.GetKey(KeyCode.S))
        {
            animNum = 2 + switchNum;
        }

        //dog is jumping
        else if(target.GetComponent<PlayerMovement>().jumping)
        {
            animNum = 1 + switchNum;
        }
        else
        {
            animNum = 0 + switchNum;
        }

    }

    void SwitchDog()
    {
        //change bool
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            dogSwitch = !dogSwitch;
        }

        //change switchNum
        if (dogSwitch)
        {
            switchNum = 3;
        }
        else
        {
            switchNum = 0;
        }
    }
}
