using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseGame : MonoBehaviour
{
    public GameObject player;
    public Camera levelCamera;
    Vector3 screenPoint;
	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        screenPoint = levelCamera.WorldToViewportPoint(player.transform.position);
        if (screenPoint.x < 0 || screenPoint.y < 0)
            SceneManager.LoadScene(1);
	}
}
