using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchObstacle : MonoBehaviour {

    // Use this for initialization
    //boolean for switchin'
    private bool samurai;
    //Arrays to store appropriate gameobjects
    private GameObject[] samuraiObjects;
    private GameObject[] policeObjects;
	void Start ()
    {
        //Start the game in non-samurai mode
        samurai = false;
        //Fill the arrays with game objects of the correct tags
        samuraiObjects = GameObject.FindGameObjectsWithTag("Samurai");
        policeObjects = GameObject.FindGameObjectsWithTag("Police");
	}
	
	// Update is called once per frame
	void Update ()
    {
        //switch the obstacles when the player presses left shift
        if (Input.GetKeyDown(KeyCode.LeftShift) && samurai)
        {
            foreach(GameObject s in samuraiObjects)
            {
                s.SetActive(true);
            }
            foreach(GameObject p in policeObjects)
            {
                p.SetActive(false);
            }
            samurai = false;
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift) && !samurai)
        {
            foreach (GameObject s in samuraiObjects)
            {
                s.SetActive(false);
            }
            foreach (GameObject p in policeObjects)
            {
                p.SetActive(true);
            }
            samurai = true;
        }


    }
}
