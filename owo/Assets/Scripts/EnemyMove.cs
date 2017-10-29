using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyMove : MonoBehaviour {

    // Use this for initialization
    //variables used for speed, speed will only be set to 0 for a second when the dog barks
    public float walkSpeed;
    private float currentSpeed;
    //The cooldown meter
    public Image slider;
    //The timers for the bark
    public float cooldownTimer;
    private float cooldown;
    //Timer used to freeze the bad guy on Bark
    private int stopTimer;
    void Start ()
    {
        currentSpeed = walkSpeed;
        stopTimer = 61;
        cooldown = cooldownTimer;
	}
	
	// Update is called once per frame
	void Update ()
    {
        cooldown += Time.deltaTime;
        //Move the dude
        transform.Translate(currentSpeed * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(KeyCode.E) && cooldown >= cooldownTimer)
        {
            currentSpeed = 0;
            stopTimer = 0;
            cooldown = 0.0f;
        }
        if (stopTimer == 20)
            currentSpeed = walkSpeed;
        stopTimer++;

        float percent;
        if (cooldown >= cooldownTimer)
        {
            percent = 1.0f;
        }
        else
        {
            percent = cooldown / cooldownTimer;
        }

        slider.fillAmount = percent;

    }
}
