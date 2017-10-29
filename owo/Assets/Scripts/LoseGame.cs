using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseGame : MonoBehaviour
{
    public GameObject player;
    private Rigidbody2D rbody;
    public Camera levelCamera;
    public float lives;
    private float iTime;

    Vector3 screenPoint;
	// Use this for initialization
	void Start ()
    {
        rbody = player.GetComponent<Rigidbody2D>();
        iTime = 10;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Rebound();
        Lose();

	}

    void Rebound()
    {
        iTime -= 10 * Time.deltaTime;
        screenPoint = levelCamera.WorldToViewportPoint(player.transform.position);
        if (screenPoint.x < 0 || screenPoint.y < -5)
        {
            rbody.AddForce(new Vector2(600, 150));
            if (iTime < 0)
            {
                lives--;
                iTime = 10;
            }
        }
    }

    void Lose()
    {
        if(lives == 0)
        {
           SceneManager.LoadScene(1);
        }
    }
}
